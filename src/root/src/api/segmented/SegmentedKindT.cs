//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using BK = SegKind;

   public readonly struct SegmentedKind<T> : ISegmentedKind<SegmentedKind<T>>
        where T : unmanaged
    {
        public BK Class {get;}

        public NumericKind CellKind
        {
            [MethodImpl(Inline)]
            get => NumericKinds.kind<T>();
        }

        [MethodImpl(Inline)]
        public SegmentedKind(SegKind kind)
            => Class = kind;

        [MethodImpl(Inline)]
        public static implicit operator SegmentedKind<T>(BK src)
            => new SegmentedKind<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator SegKind(SegmentedKind<T> src)
            => src.Class;
    }
}