//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;
    
    public static partial class RngEmitters
    {
        public static IFixedEmitter<F> fixedValue<F>(IPolyrand random)
            where F : unmanaged, IFixed
                => new FixedRngEmitter<F>(random, RngSurrogates.value<F>(random));

        /// <summary>
        /// Creates a fixed emitter that produces F-values defined over numeric T-cells
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <typeparam name="F">The fixed type</typeparam>
        public static IFixedEmitter<F,T> fixedValue<F,T>(IPolyrand random)
            where F : unmanaged, IFixed
            where T : unmanaged
                => new FixedRngEmitter<F, T>(random, RngSurrogates.value<F,T>(random));

        /// <summary>
        /// Creates a numeric emitter predicated on a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        public static NumericRngEmitter<T> numeric<T>(IPolyrand random)
            where T : unmanaged
                => new NumericRngEmitter<T>(random);

        /// <summary>
        /// Creates a fixed emitter that produces F-celled spans defined over numeric T-cells
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <typeparam name="F">The fixed type</typeparam>
        [MethodImpl(Inline)]
        public static IFixedSpanEmitter<F> fixedSpan<F>(IPolyrand random, int length)
            where F : unmanaged, IFixed
                => new FixedRngSpanEmitter<F>(random, RngSurrogates.span<F>(random,length));        


        /// <summary>
        /// Creates a fixed emitter that produces F-celled spans defined over numeric T-cells
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <typeparam name="F">The fixed type</typeparam>
        [MethodImpl(Inline)]
        public static IFixedSpanEmitter<F,T> fixedSpan<F,T>(IPolyrand random, int length)
            where F : unmanaged, IFixed
            where T : unmanaged        
                => new FixedRngSpanEmitter<F, T>(random, RngSurrogates.span<F,T>(random,length));        

        /// <summary>
        /// Creates a stream of fixed values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static IEnumerable<F> stream<F>(IPolyrand random)
            where F: unmanaged, IFixed
        {
            //var w = default(F).FixedWidth;
            var w = (FixedWidth)default(F).FixedBitCount;
            switch(w)
            {
                case FixedWidth.W8: return random.FixedStream<F>(n8);
                case FixedWidth.W16: return random.FixedStream<F>(n16);
                case FixedWidth.W32: return random.FixedStream<F>(n32);
                case FixedWidth.W64: return random.FixedStream<F>(n64);
                case FixedWidth.W128: return random.FixedStream<F>(n128);
                case FixedWidth.W256: return random.FixedStream<F>(n256);
                case FixedWidth.W512: return random.FixedStream<F>(n512);
                default: return items<F>();                    
            }
        }
    }
}