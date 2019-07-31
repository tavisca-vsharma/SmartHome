using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public interface ISwitch
    {
        void SwitchOnOff(string voiceCommand);


        // int GetStatus();
    }
}
//void SwitchOff(string voiceCommand);