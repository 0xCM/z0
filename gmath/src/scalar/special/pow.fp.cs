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
    using static AsIn;

    partial class gfp
    {
        [MethodImpl(Inline)]
        public static T pow<T>(T b, uint exp)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
               return generic<T>(fmath.pow(ref float32(ref b), exp));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.pow(ref float64(ref b), exp));
            else            
               throw unsupported<T>();            
        }

        [MethodImpl(Inline)]
        public static ref T pow<T>(ref T b, uint exp)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                fmath.pow(ref float32(ref b), exp);
            else if(typeof(T) == typeof(double))
                fmath.pow(ref float64(ref b), exp);
            else            
               throw unsupported<T>();
            
            return ref b;
        }
    }

    partial class fmath
    {

        [MethodImpl(Inline)]
        public static float pow(float src, float exp)
            => MathF.Pow(src,exp);

        [MethodImpl(Inline)]
        public static double pow(double src, double exp)
            => Math.Pow(src,exp);

        [MethodImpl(Inline)]
        public static ref float pow(ref float src, float exp)
        {
            src = MathF.Pow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double pow(ref double src, double exp)
        {
            src = Math.Pow(src,exp);
            return ref src;
        }


    }

}