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
        public static T floor<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.floor(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.floor(float64(src)));
            else
                throw unsupported<T>();
        }        

        [MethodImpl(Inline)]
        public static ref T floor<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                fmath.floor(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                fmath.floor(ref float64(ref src));
            else
                throw unsupported<T>();
            return ref src;
        }        
    }

    partial class fmath
    {
        /// <summary>
        /// Computes the largest integral value less than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float floor(float src)
            => MathF.Floor(src);

        /// <summary>
        /// Computes the largest integral value less than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double floor(double src)
            => Math.Floor(src); 

        /// <summary>
        /// Computes in-place the largest integral value less than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float floor(ref float src)
        {
            src = MathF.Floor(src);
            return ref src;
        }

        /// <summary>
        /// Computes in-place the largest integral value less than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double floor(ref double src)
        {
            src = Math.Floor(src); 
            return ref src;
        }
    }    
}