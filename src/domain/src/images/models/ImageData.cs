//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using api = DataLayouts;

    public partial struct ImageData
    {
        public readonly struct SectionHeader
        {
            public const uint Size = 40;

            [MethodImpl(NotInline)]
            public SectionHeaderData alloc()
                => new SectionHeaderData(z.alloc(Size));

            [MethodImpl(NotInline)]
            public SectionHeaderData load(byte[] src)
                => new SectionHeaderData(src);

            [MethodImpl(NotInline)]
            public SectionHeaderData load(Span<byte> src)
                => new SectionHeaderData(src);
        }

        public ref struct SectionHeaderData
        {
            readonly Span<byte> Content;

            [MethodImpl(Inline)]
            internal SectionHeaderData(Span<byte> src)
            {
                Content = src;
            }
        }
    }

}