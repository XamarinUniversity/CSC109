﻿using System;

namespace DerivedTypes
{
    public class Operation
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public Operation(int n1, int n2)
        {
            FirstNumber = n1;
            SecondNumber = n2;
        }
    }
}

