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
        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T inc<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.inc(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.inc(float64(src)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Decrements the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T inc<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                fmath.inc(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                fmath.inc(ref float64(ref src));
            else            
                throw unsupported<T>();
            return ref src;
        }           
    }

    partial class fmath
    {
        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float inc(float src)
            => src + 1;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double inc(double src)
            => src + 1;

        /// <summary>
        /// Increments the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float inc(ref float src)
        {
            src++;
            return ref src;
        }

        /// <summary>
        /// Increments the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double inc(ref double src)
        {
            src++;
            return ref src;
        }
    }    
}