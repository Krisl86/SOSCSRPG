using System;
using System.Collections.Generic;
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
                _name = value;
                base.OnPropertyChanged(nameof(Name));
            } 
        }
        public string CharacterClass
        {
            get => _characterClass;
            set
            {
                _characterClass = value;
                base.OnPropertyChanged(nameof(CharacterClass));
            }
        }
        public int HitPoints
        {
            get => _hitPoints;
            set
            {
                _hitPoints = value;
                base.OnPropertyChanged(nameof(HitPoints));
            }
        }
        public int ExperiencePoints 
        {
            get => _experiencePoints;
            set 
            { 
                _experiencePoints = value;
                base.OnPropertyChanged(nameof(ExperiencePoints));
            }
        }
        public int Level
        {
            get => _level;
            set
            {
                _level = value;
                base.OnPropertyChanged(nameof(Level));
            }
        }
        public int Gold
        {
            get => _gold;
            set
            {
                _gold = value;
                base.OnPropertyChanged(nameof(Gold));
            }
        }

    }
}
