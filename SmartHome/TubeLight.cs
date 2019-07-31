using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class TubeLight : ISwitch
    {
        private static int light = 0;
        public void SwitchOnOff(string voiceCommand)
        {
            if (voiceCommand.ToLowerInvariant() == "turn on light")
            {
                light = 1; 
            }
            else if(voiceCommand.ToLowerInvariant()=="turn off light")
                    {
                light = 0;
            }
            else
            { throw new UnrecognisedInputException("not recognised"); }
        }

       

        public static int GetStatus()
        {
            return light;
        }
    }
}

/*public void SwitchOff(string voiceCommand)
       {
           if (voiceCommand.ToLowerInvariant() == "turn off light")
           {
               light = 0;
           }
           else
           {
               throw new UnrecognisedInputException("not recognised");
           }
       }*/
