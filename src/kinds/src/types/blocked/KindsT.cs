//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using BK = BlockedKind;

   public readonly struct BlockedKind<T> : IBlockedKind<BlockedKind<T>>
        where T : unmanaged
    {
        public BK Class {get;}

        public NumericKind CellKind { [MethodImpl(Inline)] get => NumericKinds.kind<T>();}

        [MethodImpl(Inline)]
        public BlockedKind(BlockedKind kind)
        {
            this.Class = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator BlockedKind<T>(BK src)
            => new BlockedKind<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BlockedKind(BlockedKind<T> src)
            => src.Class;
    }        

    public readonly struct BlockedKind<W,T> :  IBlockedKind<BlockedKind<W,T>, W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {
        public BK Class => BlockedKinds.kind<W,T>();

        public W Width => default(W);

        public NumericKind CellKind { [MethodImpl(Inline)] get => NumericKinds.kind<T>();}

        [MethodImpl(Inline)]
        public static implicit operator BlockedKind(BlockedKind<W,T> src)
            => src.Class;

        [MethodImpl(Inline)]
        public static implicit operator BlockedKind<T>(BlockedKind<W,T> src)
            => new BlockedKind<T>(src.Class);
    } 
}