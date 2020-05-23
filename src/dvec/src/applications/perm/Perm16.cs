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
    /// Defines a 16-symbol permutation 
    /// </summary>
    public readonly ref struct Perm16
    {
        internal readonly Vector128<byte> data;

        [MethodImpl(Inline)]
        public static Perm16 Init(Vector128<byte> data)
            => new Perm16(dvec.vand(data, Vectors.vbroadcast(w, BitMasks.Msb8x8x3)));
                
        /// <summary>
        /// Creates a fixed 16-bit permutation over a generic permutation over 16 elements
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline)]
        public static Perm16 Init(Perm<byte> spec)
            => new Perm16(Vectors.vload(w, spec.Terms));

        /// <summary>
        /// Creates the identity permutation
        /// </summary>
        public static Perm16 Identity()
            => new Perm16(Data.vincrements<byte>(w));

        /// <summary>
        /// Creates the reversal of the identity permutation
        /// </summary>
        public static Perm16 Reverse()
            => new Perm16(Data.decrements<byte>(w));

        public Perm16(Vector128<byte> data)
            => this.data = data;

        static N128 w => n128;        
    }
}