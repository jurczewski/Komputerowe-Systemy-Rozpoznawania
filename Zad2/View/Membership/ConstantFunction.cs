﻿using System;
using System.Collections.Generic;
using Zad2.Membership;

namespace View.Membership
{
    class ConstantFunction : IMembershipFunction
    {
        public List<double> Parameters { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Cardinality()
        {
            return 1.0;
        }

        public List<IMembershipFunction> GetAllFunctions()
        {
            return new List<IMembershipFunction> { this };
        }

        public double GetMembership(double x)
        {
            return 1.0;
        }
    }
}
