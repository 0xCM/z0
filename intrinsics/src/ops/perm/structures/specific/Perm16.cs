//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    
    /// <summary>
    /// Defines a 16-symbol permutation 
    /// </summary>
    public readonly ref struct Perm16
    {
        internal readonly Vector128<byte> data;

        [MethodImpl(Inline)]
        public static Perm16 from(NatPerm<N16,byte> spec)
            => new Perm16(ginx.vload(w, spec.Terms));

        [MethodImpl(Inline)]
        public static Perm16 from(Vector128<byte> data)
            => new Perm16(dinx.vand(data, vbuild.broadcast(w, BitMasks.Msb8x8x3)));

        /// <summary>
        /// Creates the identity permutation
        /// </summary>
        public static Perm16 identity()
            => new Perm16(vbuild.increments<byte>(w));

        /// <summary>
        /// Creates the reversal of the identity permutation
        /// </summary>
        public static Perm16 reverse()
            => new Perm16(vbuild.decrements<byte>(w));

        Perm16(Vector128<byte> data)
            => this.data = data;

        static N128 w => n128;        

    }
}