using Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.ViewModels
{
    class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            this.CurrentPlayer = new Player
            {
                Name = "Scott",
                Gold = 0
            };
        }
    }
}
