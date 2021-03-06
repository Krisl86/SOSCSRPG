using Engine.Base;
using Engine.Command;
using Engine.Converters;
using Engine.Factories;
using Engine.Models;
using System.Linq;

namespace Engine.ViewModels
{
    public class GameSession : BaseNotificationClass
    {
        private Location _currentLocation;
        private DirectionStringToCoordinateChangeConverter _directionChange;
        public DirectionStringToCoordinateChangeConverter DirectionChange => _directionChange ?? (_directionChange = new DirectionStringToCoordinateChangeConverter());

        public Player CurrentPlayer { get; private set; }
        public World CurrentWorld { get; private set; }
        public Location CurrentLocation
        { 
            get => _currentLocation;
            private set
            {
                _currentLocation = value;
                base.OnPropertyChanged(nameof(CurrentLocation));

                GivePlayerQuestAtLocation();
            }
        }
        public RelayCommand MoveCommand { get; private set; }

        public GameSession()
        {
            this.CurrentPlayer = new Player
            {
                Name = "Scott",
                Gold = 1000000,
                CharacterClass = "Fighter",
                HitPoints = 10,
                ExperiencePoints = 0,
                Level = 1
            };

            this.CurrentWorld = WorldFactory.CreateWorld();

            this.CurrentLocation = this.CurrentWorld.LocationAt(0, -1);

            this.MoveCommand = new RelayCommand(this.Move, this.CanMove);
        }

        #region MoveCommand
        public bool CanMove(object direction)
        {
            int[] directionChange = this.DirectionChange.Convert(((string)direction).ToLower());

            return this.CurrentWorld.LocationAt(this.CurrentLocation.XCoordinate + directionChange[0],
                                                this.CurrentLocation.YCoordinate + directionChange[1]) != null;
        }

        public void Move(object direction)
        {
            if (this.CanMove(direction)) // check outside the UI if the player can move...just in case...
            {
                int[] directionChange = this.DirectionChange.Convert(((string)direction).ToLower());

                this.CurrentLocation = this.CurrentWorld.LocationAt(this.CurrentLocation.XCoordinate + directionChange[0],
                                                                    this.CurrentLocation.YCoordinate + directionChange[1]);
            } 
        }
        #endregion

        private void GivePlayerQuestAtLocation()
        {
            foreach (var quest in CurrentLocation.AvailableQuests)
            {
                if (!CurrentPlayer.Quests.Any(q => q.PlayerQuest.Id == quest.Id))
                {
                    CurrentPlayer.Quests.Add(new QuestStatus(quest));
                }
            }
        }
    }
}
