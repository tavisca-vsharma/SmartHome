using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class VoiceCommandProcessor
    {
        private ISwitch _switch;
        private string _voiceCommandGiven;
        //private CommandFactory _commandFactory = new CommandFactory();
        private CommandFactory _commandFactory;

        public VoiceCommandProcessor()
        {

        }
        public VoiceCommandProcessor(CommandFactory commandFactory)
        {
            _commandFactory = commandFactory;
        }
       
        public void SetVoiceCommand(string voiceCommandGiven)
        {
            _voiceCommandGiven = voiceCommandGiven;
            _switch= _commandFactory.ApplyVoiceCommand(voiceCommandGiven);
        }

        public void SwitchItOnOff()
        {
            _switch.SwitchOnOff(_voiceCommandGiven);
        }
        //public void SwitchItOff()
        //{
        // _switch.SwitchOff(voiceCommandGiven);
        // }

        //public VoiceCommandProcessor()
        //{

        //}
        //public VoiceCommandProcessor(string voiceCommandGiven)
        //{
        //  this.voiceCommandGiven = voiceCommandGiven;
        //}

    }
}
