using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class Fan : ISwitch
    {
        private static int fan;
        public void SwitchOnOff(string voiceCommand)
        {
            if (voiceCommand=="turn on fan")
            {
                fan = 1;
                Console.Write("checkpoint 1");
            }
            else if (voiceCommand == "turn off fan")
                    fan = 0;
            else{
                throw new UnrecognisedInputException("not recognised");
            }
        }

       

        public static int GetStatus()
        {
            return fan;
        }

    }
}
/*public void SwitchOff(string voiceCommand)
       {
           if(voiceCommand=="turn off fan")
           {
               fan = 0;
           }
           else
           {
               throw new UnrecognisedInputException("not recognised");
           }
       }*/
