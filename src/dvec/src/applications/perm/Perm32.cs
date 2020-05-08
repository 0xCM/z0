//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;    
    using static Memories;
        
    /// <summary>
    /// Defines a 32-symbol permutation
    /// </summary>
    public readonly ref struct Perm32
    {            
        internal readonly Vector256<byte> data;
        
        /// <summary>
        /// Creates a fixed 32-bit permutation over a generic permutation over 32 elements
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline), Op]
        public static Perm32 Init(Perm<byte> src)
            => new Perm32(Vectors.vload(w, src.Terms));

        [MethodImpl(Inline), Op]
        public static Perm32 Init(Vector256<byte> data)
            => new Perm32(dvec.vand(data, Vectors.vbroadcast(w, BitMasks.Msb8x8x3)));

        /// <summary>
        /// Creates the identity permutation
        /// </summary>
        [MethodImpl(Inline)]
        public static Perm32 identity()
            => new Perm32(Data.vincrements<byte>(w));

        /// <summary>
        /// Creates the reversal of the identity permutation
        /// </summary>
        [MethodImpl(Inline)]
        public static Perm32 reverse()
            => new Perm32(Data.decrements<byte>(w));

        public Perm32(Vector256<byte> data)
            => this.data = data;

        static N256 w => n256;
    }
}