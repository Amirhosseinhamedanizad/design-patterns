using System;

namespace StateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //problem
            //if(textbox.string == "valid email") {
            // checkbox.enabled = true;
            // button.enabled = true;
            //} else {
            // checkbox.enabled = false;
            // button.enabled = false;
            //} else if(textbox.string == "valid email"){
            // checkbox.enabled = true;
            // button.enabled = true;
            //textbox.enabled = false;
            //} else (textbox.string == "valid email" && textbox.string.endof("org"){
            // checkbox.enabled = true;
            // button.enabled = true;
            //textbox.enabled = false;
            //}

            //solution
            // play -> pause -> stop -> play
            Console.WriteLine("Welcome to XBox new Game Console");
            Console.WriteLine("Running Your Game ...");

            GameConsole console = new GameConsole();
            //console.SetState(new PlayingState(console));
            ////console.Play();
            //console.Pause();
            //console.Stop();

            console.SetState(new StoppedState(console));
            //console.Play();
            console.Pause();
            console.Stop();
            Console.ReadKey();
        }
    }
}
