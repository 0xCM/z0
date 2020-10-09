//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    /// <summary>
    /// Defines an untyped literal index
    /// </summary>
    public readonly struct EnumLiteralSummaries : IConstIndex<EnumLiteralSummary>
    {
        public static EnumLiteralSummaries Empty
            => new EnumLiteralSummaries(sys.empty<EnumLiteralSummary>());

        readonly EnumLiteralSummary[] Data;

        [MethodImpl(Inline)]
        public static implicit operator EnumLiteralSummaries(EnumLiteralSummary[] src)
            => new EnumLiteralSummaries(src);

        [MethodImpl(Inline)]
        public EnumLiteralSummaries(EnumLiteralSummary[] src)
            => Data = src;

        public ReadOnlySpan<EnumLiteralSummary> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<EnumLiteralSummary> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref readonly EnumLiteralSummary this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public ref readonly EnumLiteralSummary this[uint i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public variant[] Values
            => Data.Select(x => x.ScalarValue);

        public F[] Convert<F>()
            where F : unmanaged, Enum
        {
            var src = Values;
            var dst = new F[src.Length];

            for(var i=0; i< src.Length; i++)
                dst[i] = (F)(object)src[i];
            return dst;
        }

        public EnumLiteralSummaries Append(EnumLiteralSummaries more)
            => new EnumLiteralSummaries(Data.Concat(more.Data).Array());

        public IEnumerable<NamedValue<variant>> NamedValues
            => from i in Data select NamedValue.define(i.LiteralName, i.ScalarValue);
    }
}