//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static As;
    using static zfunc;

    partial class fmath
    {

        [MethodImpl(Inline)]
        public static bool within(float lhs, float rhs, float epsilon)
            => lhs > rhs ? lhs - rhs <= epsilon 
              : rhs - lhs <= epsilon;

        [MethodImpl(Inline)]
        public static bool within(double lhs, double rhs, double epsilon)
            => lhs > rhs ? lhs - rhs <= epsilon 
              : rhs - lhs <= epsilon;

 
        [MethodImpl(Inline)]
        public static double width(float lhs, float rhs)
            => math.abs((double)rhs - (double)lhs);

        [MethodImpl(Inline)]
        public static double width(double lhs, double rhs)
            => abs(rhs - lhs);

    }

}