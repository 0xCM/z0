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
        public struct text7 : IName<text7,ulong>
        {
            public const byte MaxLength = 7;

            public const uint SZ = PrimalSizes.U64;

            public ulong Storage;

            public byte PointSize
                => 1;

            static N7 N => default;

            [MethodImpl(Inline)]
            internal text7(in ulong data)
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
                get => (uint)(Storage >> 56)&0xFF;
            }

            public string Format()
                => O.format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public bool Equals(text7 src)
                => O.eq(this,src);

            public override bool Equals(object src)
                => src is text7 n ? Equals(n) : false;

            public override int GetHashCode()
                => (int)O.hash(this);

            [MethodImpl(Inline)]
            public static bool operator ==(text7 a, text7 b)
                => a.Equals(b);

            [MethodImpl(Inline)]
            public static bool operator !=(text7 a, text7 b)
                => !a.Equals(b);

            [MethodImpl(Inline)]
            public static implicit operator text7(string src)
                => F.text(N,src);

            [MethodImpl(Inline)]
            public static implicit operator text7(ReadOnlySpan<char> src)
                => F.text(N,src);

            [MethodImpl(Inline)]
            public static implicit operator textT<ulong>(text7 src)
                => new textT<ulong>(src.Storage, src.Length, src.PointSize);

            public static text7 Empty => default;
        }
    }
}