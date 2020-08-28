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
    public readonly struct EnumLiteralDetails : IConstIndex<EnumLiteralDetail>
    {
        public static EnumLiteralDetails Empty
            => new EnumLiteralDetails(sys.empty<EnumLiteralDetail>());

        readonly EnumLiteralDetail[] Data;

        [MethodImpl(Inline)]
        public static implicit operator EnumLiteralDetails(EnumLiteralDetail[] src)
            => new EnumLiteralDetails(src);

        [MethodImpl(Inline)]
        public EnumLiteralDetails(EnumLiteralDetail[] src)
            => Data = src;

        public ReadOnlySpan<EnumLiteralDetail> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<EnumLiteralDetail> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref readonly EnumLiteralDetail this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public ref readonly EnumLiteralDetail this[uint i]
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

        public EnumLiteralDetails Append(EnumLiteralDetails more)
            => new EnumLiteralDetails(Data.Concat(more.Data).Array());

        public IEnumerable<NamedValue<variant>> NamedValues
            => from i in Data select NamedValue.define(i.LiteralName, i.ScalarValue);
    }
}