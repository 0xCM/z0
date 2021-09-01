//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using F = Blit.Factory;
    using O = Blit.Operate;

    partial struct Blit
    {
        public struct text15 : IName<text15,Cell128>
        {
            public const uint StorageSize = 16;

            public const byte MaxLength = 15;

            public static W128 W => default;

            static N15 N => default;

            public Cell128 Storage;

            public byte PointSize
                => 1;

            [MethodImpl(Inline)]
            internal text15(in Cell128 data)
            {
                Storage = data;
            }

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => slice(bytes(Storage),0, MaxLength);
            }

            public uint Length
            {
                [MethodImpl(Inline)]
                get => Storage.Cell(w8, 15);
            }

            public string Format()
                => Render.format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator text15(string src)
                => F.text(N,src);

            [MethodImpl(Inline)]
            public static implicit operator text15(ReadOnlySpan<char> src)
                => F.text(N,src);

            [MethodImpl(Inline)]
            public static implicit operator textT<Cell128>(text15 src)
                => new textT<Cell128>(src.Storage, src.Length, src.PointSize);

            public static text15 Empty => default;
        }
    }
}