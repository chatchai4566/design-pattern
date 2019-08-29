﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Director
    {
        private IBuilder builder;

        public void Construct(IBuilder builder)
        {
            this.builder = builder;

            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadlights();
            builder.EndOperatons();
        }
    }
}