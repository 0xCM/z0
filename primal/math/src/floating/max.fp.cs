//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    

    partial class fmath
    {

        [MethodImpl(Inline)]
        public static float max(float lhs, float rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static double max(double lhs, double rhs)
            => lhs > rhs ? lhs : rhs;

        [MethodImpl(Inline)]
        public static ref float max(ref float lhs, float rhs)
        {
            lhs = lhs > rhs ? lhs : rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double max(ref double lhs, double rhs)
        {
            lhs = lhs > rhs ? lhs : rhs;
            return ref lhs;
        }
    }
}