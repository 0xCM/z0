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
        public static bit within(float lhs, float rhs, float epsilon)
            => lhs > rhs ? lhs - rhs <= epsilon 
              : rhs - lhs <= epsilon;

        [MethodImpl(Inline)]
        public static bit within(double lhs, double rhs, double epsilon)
            => lhs > rhs ? lhs - rhs <= epsilon 
              : rhs - lhs <= epsilon;
    }
}