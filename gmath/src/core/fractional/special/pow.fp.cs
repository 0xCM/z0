//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    
    using static As;
    using static AsIn;

    partial class gfp
    {
        [MethodImpl(Inline), NumericClosures(NumericKind.Floats)]
        public static T pow<T>(T b, uint exp)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
               return generic<T>(fmath.pow(float32(b), exp));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.pow(float64(b), exp));
            else            
               throw unsupported<T>();            
        }
    }

    partial class fmath
    {

        [MethodImpl(Inline), Op]
        public static float pow(float src, float exp)
            => MathF.Pow(src,exp);

        [MethodImpl(Inline), Op]
        public static double pow(double src, double exp)
            => Math.Pow(src,exp);
    }
}