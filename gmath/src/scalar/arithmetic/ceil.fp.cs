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
        public static T ceil<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.ceil(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.ceil(float64(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ref T ceil<T>(ref T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                fmath.ceil(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                fmath.ceil(ref float64(ref src));
            else
                throw unsupported<T>();
            return ref src;
        }        

    }

    partial class fmath
    {
        /// <summary>
        /// Computes the smallest integral value greater than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float ceil(float src)
            => MathF.Ceiling(src);

        /// <summary>
        /// Computes in-place the smallest integral value greater than or equal to the source value
        /// </summary>
        /// <param name="src">The source value to be overwritten with the computation</param>
        [MethodImpl(Inline)]
        public static ref float ceil(ref float src)
        {
            src = MathF.Ceiling(src);
            return ref src;
        }

        /// <summary>
        /// Computes the smallest integral value greater than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double ceil(double src)
            => Math.Ceiling(src);

        /// <summary>
        /// Computes in-place the smallest integral value greater than or equal to the source value
        /// </summary>
        /// <param name="src">The source value to be overwritten with the computation</param>
        [MethodImpl(Inline)]
        public static ref double ceil(ref double src)
        {
            src = Math.Ceiling(src);
            return ref src;
        }
    }    
}