//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using BK = BlockedKind;

    public readonly struct BlockedKind<W,T> : IBlockedOp<BlockedKind<W,T>, W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {
        [MethodImpl(Inline)]
        public static implicit operator BlockedKind(BlockedKind<W,T> src)
            => src.Class;

        [MethodImpl(Inline)]
        public static implicit operator BlockedKind<T>(BlockedKind<W,T> src)
            => new BlockedKind<T>(src.Class);

        public BK Class
        {
            [MethodImpl(Inline)]
            get => BlockedKinds.kind<W,T>();
        }

        public W Width
            => default(W);

        public NumericKind CellKind
        {
            [MethodImpl(Inline)]
            get => NumericKinds.kind<T>();
        }
    }
}