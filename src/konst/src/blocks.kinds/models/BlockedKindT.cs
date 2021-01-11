//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using BK = SegBlockKind;

   public readonly struct BlockedKind<T> : IBlockedOpKind<BlockedKind<T>>
        where T : unmanaged
    {
        public BK Class {get;}

        public NumericKind CellKind
        {
            [MethodImpl(Inline)]
            get => Numeric.kind<T>();
        }

        [MethodImpl(Inline)]
        public BlockedKind(SegBlockKind kind)
            => Class = kind;

        [MethodImpl(Inline)]
        public static implicit operator BlockedKind<T>(BK src)
            => new BlockedKind<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator SegBlockKind(BlockedKind<T> src)
            => src.Class;
    }
}