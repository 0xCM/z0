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
    public readonly ref struct Perm16Spec
    {
        internal readonly Vector128<byte> data;

        [MethodImpl(Inline)]
        public static Perm16Spec from(NatPerm<N16,byte> spec)
            => new Perm16Spec(ginx.vload(w, spec.Terms));

        [MethodImpl(Inline)]
        public static Perm16Spec from(Vector128<byte> data)
            => new Perm16Spec(dinx.vand(data, vbuild.broadcast(w, BitMasks.Msb8x8x3)));

        /// <summary>
        /// Creates the identity permutation
        /// </summary>
        public static Perm16Spec identity()
            => new Perm16Spec(vbuild.increments<byte>(w));

        /// <summary>
        /// Creates the reversal of the identity permutation
        /// </summary>
        public static Perm16Spec reverse()
            => new Perm16Spec(vbuild.decrements<byte>(w));

        Perm16Spec(Vector128<byte> data)
            => this.data = data;

        static N128 w => n128;        

    }
}