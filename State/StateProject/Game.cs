using System;
using System.Collections.Generic;
using System.Text;

namespace StateProject
{
    //State
    public interface State
    {
        void Pause();
        void Stop();
        void Play();
    }

    //Playing Concerete Class
    public class PlayingState : State
    {
        private GameConsole _game;
        public PlayingState(GameConsole game)
        {
            _game = game;
        }
        public void Pause()
        {
            _game.SetState(_game.getPausedgState());
            Console.WriteLine("Pausing");
        }

        public void Play()
        {
            Console.WriteLine("Already Playing");
        }

        public void Stop()
        {
            _game.SetState(_game.getStoppedState());
            Console.WriteLine("Stopping");
        }
    }

    //Puased Concerete Class
    public class PausedState : State
    {
        private GameConsole _game;
        public PausedState(GameConsole game)
        {
            _game = game;
        }

        public void Pause()
        {
            Console.WriteLine("Already Paused");
        }

        public void Play()
        {
            _game.SetState(_game.getPlayingState());
            Console.WriteLine("Playing");
        }

        public void Stop()
        {
            _game.SetState(_game.getStoppedState());
            Console.WriteLine("Stopping");
        }
    }


    //Stopped Concerete Class
    public class StoppedState : State
    {
        private GameConsole _game;
        public StoppedState(GameConsole game)
        {
            _game = game;
        }

        public void Pause()
        {
            Console.WriteLine("not possible to do this action");
        }

        public void Play()
        {
            _game.SetState(_game.getPlayingState());
            Console.WriteLine("Playing");
        }

        public void Stop()
        {
            Console.WriteLine("Already Stopped");
        }
    }
}
