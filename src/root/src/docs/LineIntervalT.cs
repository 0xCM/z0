//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct LineInterval<T>
    {
        public T Id {get;}

        public LineNumber MinLine {get;}

        public LineNumber MaxLine {get;}

        [MethodImpl(Inline)]
        public LineInterval(T id, LineNumber min, LineNumber max)
        {
            Id = id;
            MinLine = min;
            MaxLine = max;
        }

        public uint LineCount
        {
            [MethodImpl(Inline)]
            get => MaxLine.Value - MinLine.Value;
        }

        public string Format()
            => string.Format("{0}:[{1}..{2}]({3})", Id, MinLine, MaxLine, LineCount);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator LineInterval<T>((T id, LineNumber min, LineNumber max) src)
            => new LineInterval<T>(src.id,src.min, src.max);
    }
}