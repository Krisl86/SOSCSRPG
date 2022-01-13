using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Engine.Base;

namespace Engine.Models
{
    public class Player : BaseNotificationClass
    {
        private string _name;
        private string _characterClass;
        private int _hitPoints;
        private int _experiencePoints;
        private int _level;
        private int _gold;

        public string Name 
        {
            get => _name;
            set
            {
                if (value != _name)
                {
                    _name = value;
                    base.OnPropertyChanged(nameof(Name));
                }  
            } 
        }
        public string CharacterClass
        {
            get => _characterClass;
            set
            {
                if (value != _characterClass)
                {
                    _characterClass = value;
                    base.OnPropertyChanged(nameof(CharacterClass));
                }      
            }
        }
        public int HitPoints
        {
            get => _hitPoints;
            set
            {
                if (value != _hitPoints)
                {
                    _hitPoints = value;
                    base.OnPropertyChanged(nameof(HitPoints));
                }
            }
        }
        public int ExperiencePoints 
        {
            get => _experiencePoints;
            set 
            {
                if (value != _experiencePoints)
                {
                    _experiencePoints = value;
                    base.OnPropertyChanged(nameof(ExperiencePoints));
                }  
            }
        }
        public int Level
        {
            get => _level;
            set
            {
                if (value != _level)
                {
                    _level = value;
                    base.OnPropertyChanged(nameof(Level));
                }
            }
        }
        public int Gold
        {
            get => _gold;
            set
            {
                if (value != _gold)
                {
                    _gold = value;
                    base.OnPropertyChanged(nameof(Gold));
                }
            }
        }
        public ObservableCollection<GameItem> Inventory { get; set; }

        public ObservableCollection<QuestStatus> Quests { get; set; }

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
            Quests = new ObservableCollection<QuestStatus>();
        }
    }
}
