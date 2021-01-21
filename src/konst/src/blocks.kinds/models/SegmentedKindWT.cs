//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using BK = SegKind;

    public readonly struct SegmentedKind<W,T> : ISegmetedKind<SegmentedKind<W,T>, W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {
        public BK Class
        {
            [MethodImpl(Inline)]
            get => SegmentedKinds.kind<W,T>();
        }

        public W Width
            => default(W);

        public NumericKind CellKind
        {
            [MethodImpl(Inline)]
            get => Numeric.kind<T>();
        }

        [MethodImpl(Inline)]
        public static implicit operator SegKind(SegmentedKind<W,T> src)
            => src.Class;

        [MethodImpl(Inline)]
        public static implicit operator SegmentedKind<T>(SegmentedKind<W,T> src)
            => new SegmentedKind<T>(src.Class);
    }
}