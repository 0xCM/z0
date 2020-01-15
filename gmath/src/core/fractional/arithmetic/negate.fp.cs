//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Floats)]
        public static T negate<T>(T lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.negate(float32(lhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.negate(float64(lhs)));
            else            
                throw unsupported<T>();
        }
    }

    partial class fmath
    {
        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static float negate(float src)
            => -src;

        /// <summary>
        /// Negates the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static double negate(double src)
            => -src;
    }    
}