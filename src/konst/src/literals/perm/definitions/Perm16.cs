//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    /// <summary>
    /// Defines a 16-symbol permutation 
    /// </summary>
    public readonly struct Perm16
    {
        public readonly Vector128<byte> data;

        [MethodImpl(Inline)]
        public Perm16(Vector128<byte> data)
            => this.data = data;
    }
}