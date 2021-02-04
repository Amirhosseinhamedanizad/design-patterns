using System;
using System.Collections.Generic;
using System.Text;

namespace StateProject
{
    public class GameConsole
    {
        private State _state;
        private PlayingState playingState;
        private PausedState pausedState;
        private StoppedState stoppedState;

        public GameConsole()
        {
            playingState = new PlayingState(this);
            pausedState = new PausedState(this);
            stoppedState = new StoppedState(this);
        }

        public State getPlayingState()
        {
            return playingState;
        }

        public State getPausedgState()
        {
            return pausedState;
        }

        public State getStoppedState()
        {
            return stoppedState;
        }

        public void SetState(State state)
        {
            _state = state;
        }

        public void Play()
        {
            _state.Play();
        }

        public void Pause()
        {
            _state.Pause();
        }

        public void Stop()
        {
            _state.Stop();
        }
    }


}
