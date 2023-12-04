using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class EventsControllerTest
    {
        private readonly EventsControllerTest _controller;

        public EventsControllerTest()
        {
            var context=new DataContextFake();
           // _controller = new (context);
        }
    }
}
