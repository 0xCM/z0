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
    public readonly ref struct Perm32
    {            
        /// <summary>
        /// Creates the identity permutation
        /// </summary>
        public static Perm32 identity()
            => new Perm32(ginx.vincrements<byte>(n256));

        /// <summary>
        /// Creates the reversal of the identity permutation
        /// </summary>
        public static Perm32 reverse()
            => new Perm32(ginx.vdecrements<byte>(n256));

        internal readonly Vector256<byte> data;

        internal Perm32(Vector256<byte> data)
            => this.data = data;
    }

}