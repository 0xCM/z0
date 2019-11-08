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
        public static bit lt(float lhs, float rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bit lt(double lhs, double rhs)
            => lhs < rhs;        

        [MethodImpl(Inline)]
        public static bit lteq(float lhs, float rhs)
            => lhs <= rhs;

        [MethodImpl(Inline)]
        public static bit lteq(double lhs, double rhs)
            => lhs <= rhs;        

    }

}