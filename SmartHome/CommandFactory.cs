using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class CommandFactory
    {
        public ISwitch ApplyVoiceCommand(string _voiceCommand)
        {
            string[] commandArray = _voiceCommand.ToLowerInvariant().Split(' ');
            switch (commandArray[commandArray.Length - 1])
            {
                case "fan":
                    //new VoiceCommandProcessor(new Fan(), _voiceCommand).SwitchItOnOff();
                    //Console.WriteLine("checkpoint 3");
                    return new Fan();
                case "light":
                    //new VoiceCommandProcessor(new TubeLight(), _voiceCommand).SwitchItOnOff();
                    return new TubeLight();

                default: throw new UnrecognisedInputException("not supported Command");
                    
            }
            //return null;
        }

    }
}
