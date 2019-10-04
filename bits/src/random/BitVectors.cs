//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;
    using static nfunc;

    using BV = Z0.BitVector;

    public static partial class BitRng
    {

        /// <summary>
        /// Produces a stream of random 4-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IRandomStream<BitVector4> BitVectors(this IPolyrand random, N4 n)
        {
            IEnumerable<BitVector4> produce()
            {            
                while(true)
                    yield return random.BitVector(n4);
            }

            return stream(produce(), random.RngKind);            
        }

        /// <summary>
        /// Produces a stream of random 8-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IRandomStream<BitVector8> BitVectors(this IPolyrand random, N8 n)
        {
            IEnumerable<BitVector8> produce()
            {            
                while(true)
                    yield return random.BitVector(n);
            }

            return stream(produce(), random.RngKind);            
        }            


        /// <summary>
        /// Produces a stream of random 32-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IRandomStream<BitVector32> BitVectors(this IPolyrand random, N32 n)
        {
            IEnumerable<BitVector32> produce()
            {
                while(true)
                    yield return random.BitVector(n);

            }
            return stream(produce(), random.RngKind);
        }            

        /// <summary>
        /// Produces a stream of random 64-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IRandomStream<BitVector64> BitVectors(this IPolyrand random, N64 n)
        {
            IEnumerable<BitVector64> produce()
            {
                while(true)
                    yield return random.BitVector(n);
            }
            return stream(produce(), random.RngKind);
        }            

        /// <summary>
        /// Produces a stream of random 128-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IRandomStream<BitVector128> BitVectors(this IPolyrand random, N128 n)
        {
            IEnumerable<BitVector128> produce()
            {
                while(true)
                    yield return random.BitVector(n);

            }
            return stream(produce(), random.RngKind);
        }            
    }

}