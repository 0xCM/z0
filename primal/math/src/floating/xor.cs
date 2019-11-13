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
        public static float xor(float a, float b)
            => BitConvert.ToSingle(a.ToBits() ^ b.ToBits());

        [MethodImpl(Inline)]
        public static double xor(double a, double b)
            => BitConvert.ToDouble(a.ToBits() ^ b.ToBits());         
        
        [MethodImpl(Inline)]
        public static ref float xor(ref float a, float b)
        {
            a = xor(a,b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref double xor(ref double a, double b)
        {
            a = xor(a,b);
            return ref a;
        }
    }
}