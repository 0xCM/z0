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
        public static ref float and(ref float a, float b)
        {
            a = and(a,b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref double and(ref double a, double b)
        {
            a = and(a,b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static float and(float a, float b)
            => BitConvert.ToSingle(a.ToBits() &  b.ToBits());

        [MethodImpl(Inline)]
        public static double and(double a, double b)
            => BitConvert.ToDouble(a.ToBits() &  b.ToBits());
    }
}