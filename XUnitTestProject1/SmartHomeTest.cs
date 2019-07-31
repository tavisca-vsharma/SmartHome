using System;
using Xunit;
using SmartHome;

namespace XUnitTestProject1
{
    public class SmartHomeTest
    {
        private SmartHomee _hometest = new SmartHomee();
        
        public SmartHomeTest()
        {

        }
        [Fact]
        public void FanOffTest()
        {
            string command = "turn off fan";
            _hometest.SetCommand(command);
            int actual = 0;
            //int result=_hometest.GetStatus(new Fan());
            int result = Fan.GetStatus();
            Assert.Equal(actual, result);
        }


        [Fact]
        public void FanOnTest()
        {
            string command = "turn on fan";
            _hometest.SetCommand(command);
            int actual = 1;
            //int result = _hometest.GetStatus(new Fan());
            int result = Fan.GetStatus();
            Assert.Equal(actual, result);
        }

        [Fact]
        public void FanOnTestWithWrongInput()
        {
            string command = "turn onnn fan";
            Assert.Throws<UnrecognisedInputException>(()=>_hometest.SetCommand(command));
        }

        [Fact]
        public void FanOnTestWithTooWrongInput()
        {
            string command = "turn onnn fannnnn";
            Assert.Throws<UnrecognisedInputException>(() => _hometest.SetCommand(command));
        }

        [Fact]
        public void LightOffTest()
        {
            string command = "turn off Light";
            _hometest.SetCommand(command);
            int actual = 0;
            //int result=_hometest.GetStatus();
            int result = TubeLight.GetStatus();
            Assert.Equal(actual, result);
        }


        [Fact]
        public void LightOnTest()
        {
            string command = "turn on Light";
            _hometest.SetCommand(command);
            int actual = 1;
            //int result = _hometest.GetStatus(new Fan());
            int result = TubeLight.GetStatus();
            Assert.Equal(actual, result);
        }

        [Fact]
        public void LightOnTestWithWrongInput()
        {
            string command = "turn onnn fan";
            Assert.Throws<UnrecognisedInputException>(() => _hometest.SetCommand(command));
        }

        [Fact]
        public void LightOnTestWithTooWrongInput()
        {
            string command = "turn onnn fannnnn";
            Assert.Throws<UnrecognisedInputException>(() => _hometest.SetCommand(command));
        }
    }
}
