//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static As;
    using static zfunc;

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static double width(float lhs, float rhs)
            => abs((double)rhs - (double)lhs);

        [MethodImpl(Inline)]
        public static double width(double lhs, double rhs)
            => abs(rhs - lhs);
    }
}