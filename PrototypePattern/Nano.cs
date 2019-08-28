﻿namespace PrototypePattern
{
    public class Nano : BasicCar
    {
        public Nano(string m)
        {
            base.ModelName = m;
        }

        public override BasicCar Clone()
        {
            return (Nano)this.MemberwiseClone();
        }
    }
}