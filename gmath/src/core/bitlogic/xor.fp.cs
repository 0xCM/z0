//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
 
    using static AsIn;

    partial class gfp
    {
       [MethodImpl(Inline)]
       public static T xor<T>(T a, T b)
            where T :unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.xor(float32(a), float32(b)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.xor(float64(a), float64(b)));
            else
                throw unsupported<T>();
        }
    }

    partial class fmath
    {
        [MethodImpl(Inline)]
        public static float xor(float a, float b)
            => BitConvert.ToSingle(a.ToBits() ^ b.ToBits());

        [MethodImpl(Inline)]
        public static double xor(double a, double b)
            => BitConvert.ToDouble(a.ToBits() ^ b.ToBits());                 
    }
}