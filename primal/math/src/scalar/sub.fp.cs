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
    using static AsIn;
    using static zfunc;

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static float sub(float lhs, float rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static double sub(double lhs, double rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public static ref float sub(ref float lhs, float rhs)
        {
            lhs = lhs - rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double sub(ref double lhs, double rhs)
        {
            lhs = lhs - rhs;
            return ref lhs;
        }
    }
}