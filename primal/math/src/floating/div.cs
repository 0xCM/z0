//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    
    partial class fmath
    {
        [MethodImpl(Inline)]
        public static float div(float lhs, float rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static double div(double lhs, double rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public static ref float div(ref float lhs, in float rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double div(ref double lhs, in double rhs)
        {
            lhs = lhs / rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static bit divides(float a, float b)
            => b % a == 0;

        [MethodImpl(Inline)]
        public static bit divides(double a, double b)
            => b % a == 0;
    }
}