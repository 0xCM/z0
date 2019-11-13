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
        public static float min(float a, float b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static double min(double a, double b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static ref float min(ref float a, float b)
        {
            a = a < b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref double min(ref double a, double b)
        {
            a = a < b ? a : b;
            return ref a;
        }
    }
}