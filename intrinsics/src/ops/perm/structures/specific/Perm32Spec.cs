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
    /// Defines a 32-symbol permutation
    /// </summary>
    public readonly ref struct Perm32Spec
    {            
        internal readonly Vector256<byte> data;
        
        [MethodImpl(Inline)]
        public static Perm32Spec from(NatPerm<N32,byte> spec)
            => new Perm32Spec(ginx.vload(w, spec.Terms));

        [MethodImpl(Inline)]
        public static Perm32Spec from(Vector256<byte> data)
            => new Perm32Spec(dinx.vand(data, vbuild.broadcast(w, BitMasks.Msb8x8x3)));

        /// <summary>
        /// Creates the identity permutation
        /// </summary>
        [MethodImpl(Inline)]
        public static Perm32Spec identity()
            => new Perm32Spec(vbuild.increments<byte>(w));

        /// <summary>
        /// Creates the reversal of the identity permutation
        /// </summary>
        [MethodImpl(Inline)]
        public static Perm32Spec reverse()
            => new Perm32Spec(vbuild.decrements<byte>(w));

        Perm32Spec(Vector256<byte> data)
            => this.data = data;

        static N256 w => n256;
    }
}