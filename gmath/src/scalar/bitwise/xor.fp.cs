//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gfp
    {
       [MethodImpl(Inline)]
       public static T xor<T>(T a, T b)
            where T :unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(BitConvert.ToSingle(float32(a).ToBits() ^ float32(b).ToBits()));
            else if(typeof(T) == typeof(double))
                return generic<T>(BitConvert.ToDouble(float64(a).ToBits() ^  float64(b).ToBits()));
            else
                throw unsupported<T>();
        }

       [MethodImpl(Inline)]
       public static ref T xor<T>(ref T a, T b)
            where T :unmanaged
        {
            a = xor(a,b);
            return ref a;
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