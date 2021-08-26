//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct LineMap<T>
    {
        readonly LineInterval<T>[] _Intervals;

        [MethodImpl(Inline)]
        public LineMap(LineInterval<T>[] src)
        {
            _Intervals = src;
        }

        public Span<LineInterval<T>> Intervals
        {
            [MethodImpl(Inline)]
            get => _Intervals;
        }

        [MethodImpl(Inline)]
        public static implicit operator LineMap<T>(LineInterval<T>[] src)
            => new LineMap<T>(src);
    }
}