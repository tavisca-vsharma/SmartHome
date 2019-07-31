using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class SmartHomee
    {
        private VoiceCommandProcessor _voiceCommand = new VoiceCommandProcessor(new CommandFactory());
        //private Fan _fan = new Fan();
        //private TubeLight _light = new TubeLight();
        private ISwitch _switch;
        public void SetCommand(string command)
        {
            try {
                _voiceCommand.SetVoiceCommand(command);
                _voiceCommand.SwitchItOnOff();
            }catch(UnrecognisedInputException e)
            {
                throw e;
            }
            
        }


        //public int GetStatus(ISwitch switchh)
        //{
        //    _switch = switchh;
        //    return _switch.GetStatus();
        //}



    }
}
