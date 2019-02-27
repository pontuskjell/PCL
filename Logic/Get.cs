using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
   public class Get
    {
        public Get() { }

        public Hello GetHello()
        {
            var hello = new Hello();
            hello.Name = "Jesper";
            return hello;
        }
    }
}
