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

   public readonly struct BlockedKind<T> : IBlockedKind<BlockedKind<T>>
        where T : unmanaged
    {
        public BK Class {get;}

        [MethodImpl(Inline)]
        public static implicit operator BlockedKind<T>(BK src)
            => new BlockedKind<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BlockedKind(BlockedKind<T> src)
            => src.Class;

        public NumericKind CellKind
        {
            [MethodImpl(Inline)]
            get => NumericKinds.kind<T>();
        }

        [MethodImpl(Inline)]
        public BlockedKind(BlockedKind kind)
            => Class = kind;
    }
}