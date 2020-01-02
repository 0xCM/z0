//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static As;
    using static zfunc;

    partial class gfp
    {
        [MethodImpl(Inline)]
        public static T square<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.square(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.square(float64(src)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T square<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                fmath.square(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                fmath.square(ref float64(ref src));
            else 
                throw unsupported<T>();
            return ref src;
        }           
    }

    partial class fmath
    {

        [MethodImpl(Inline)]
        public static float square(float src)
            => fmath.mul(src,src);

        [MethodImpl(Inline)]
        public static double square(double src)
            => fmath.mul(src,src);


        [MethodImpl(Inline)]
        public static ref float square(ref float src)
        {
            src *= src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double square(ref double src)
        {
            src *= src;
            return ref src;
        }
    }    

    partial class fmath
    {
        /// <summary>
        /// Computes the square root of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float sqrt(float src)
            => MathF.Sqrt(src);

        /// <summary>
        /// Computes the square root of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double sqrt(double src)
            => Math.Sqrt(src); 

        /// <summary>
        /// Computes the square root of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float sqrt(ref float src)
        {
            src = MathF.Sqrt(src);
            return ref src;
        }

        /// <summary>
        /// Computes the square root of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double sqrt(ref double src)
        {
            src = Math.Sqrt(src);
            return ref src;
        }

        /// <summary>
        /// Computes the square root of the source and stores the result 
        /// in a specified target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline)]
        public static ref float sqrt(in float src, ref float dst)
        {
            dst = sqrt(src);
            return ref dst;
        }

        /// <summary>
        /// Computes the square root of the source and stores the result 
        /// in a specified target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline)]
        public static ref double sqrt(in double src, ref double dst)
        {
            dst = sqrt(src);
            return ref dst;
        }

    }

}
