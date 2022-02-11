using System;

namespace Common
{
    /*     
       Public
       Private
       Protected
       Internal
       Protected internal
    */
    public class Car
    {
        public string Model { get; set; }
        protected string Manufacturer { get; set; }
        internal string Color { get; set; }
        private bool IsMoving { get; set; }
        protected internal string Capacity { get; set; }

        public void Drive()
        {
            IsMoving = true;
        }

        public void Park()
        {
            IsMoving = false;
        }

        protected void StartEngine()
        {

        }
    }
}
