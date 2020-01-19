//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public readonly struct BlockKind<W,T> : IBlockKind<W,T>
        where W : unmanaged, ITypeNat
        where T : unmanaged            
    {
        [MethodImpl(Inline)]
        public static implicit operator BlockKind(BlockKind<W,T> b)
            => b.Classifier;

        public BlockKind Classifier { [MethodImpl(Inline)] get=> BlockedType.kind<W,T>();}
    }
}