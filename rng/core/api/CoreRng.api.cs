//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;


    public static class CoreRng
    {
        [MethodImpl(Inline)]
        public static IRngStream<T> stream<T>(IEnumerable<T> src, RngKind rng)
            where T : struct
                => RandomStream.From(src,rng);

        /// <summary>
        /// Defines a default T-valued domain
        /// </summary>
        /// <typeparam name="T">The domain type</typeparam>
        public static Interval<T> domain<T>()
            where T : unmanaged
        {            
            if(typeof(T) == typeof(double))
                return (convert<T>(long.MinValue/2), convert<T>(long.MaxValue/2));
            else if(typeof(T) == typeof(float))
                return (convert<T>(int.MinValue/2), convert<T>(int.MaxValue/2));
            else
            {
                var min = Numeric.signed<T>() 
                    ? gmath.negate(gmath.sar(maxval<T>(), 1)) 
                    : minval<T>();                        
                
                var max = Numeric.signed<T>() 
                    ? gmath.sar(maxval<T>(), 1) 
                    : maxval<T>();

                return (min,max);
            }            
        }

        /// <summary>
        /// Creates a polyrand rng from a point source
        /// </summary>
        /// <param name="rng">The source rng</param>
        public static IPolyrand polyrand(IRngBoundPointSource<ulong> src)        
            => Polyrand.Create(src);

        /// <summary>
        /// Creates a polyrand based on a specified source
        /// </summary>
        /// <param name="src">The random source</param>
        [MethodImpl(Inline)]
        public static IPolyrand polynav(IRngNav<ulong> src)
            => Polyrand.Create(src);

        /// <summary>
        /// Presents the polysource as a point source
        /// </summary>
        /// <param name="src">The randon source</param>
        /// <typeparam name="T">The point type</typeparam>
        [MethodImpl(Inline)]
        public static IRngPointSource<T> points<T>(IPolyrand src)
            where T : unmanaged
                => src as IRngPointSource<T>;
    }
}