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
        public readonly struct name<T> : IName<name<T>,T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public static uint MaxLength(byte psz)
                => size<T>()*psz - 1;

            public T Storage {get;}

            public uint Length {get;}

            public byte PointSize {get;}

            [MethodImpl(Inline)]
            public name(T data, uint length, byte psz)
            {
                Storage= data;
                Length = length;
                PointSize = psz;
            }

            public Span<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => slice(bytes(Storage),0, MaxLength(PointSize));
            }
        }

        public struct name64 : IName<name64,ulong>
        {
            public const byte MaxLength = 7;

            public const uint StorageSize = PrimalSizes.U64;

            public ulong Storage;

            public byte PointSize
                => 1;

            public static W64 W => default;

            [MethodImpl(Inline)]
            internal name64(in ulong data)
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
            public bool Equals(name64 src)
                => O.eq(this,src);

            public override bool Equals(object src)
                => src is name64 n ? Equals(n) : false;

            public override int GetHashCode()
                => (int)O.hash(this);

            [MethodImpl(Inline)]
            public static bool operator ==(name64 a, name64 b)
                => a.Equals(b);

            [MethodImpl(Inline)]
            public static bool operator !=(name64 a, name64 b)
                => !a.Equals(b);

            [MethodImpl(Inline)]
            public static implicit operator name64(string src)
                => F.name(W,src);

            [MethodImpl(Inline)]
            public static implicit operator name64(ReadOnlySpan<char> src)
                => F.name(W,src);

            [MethodImpl(Inline)]
            public static implicit operator name<ulong>(name64 src)
                => new name<ulong>(src.Storage, src.Length, src.PointSize);
        }

        public struct name128 : IName<name128,Cell128>
        {
            public const uint StorageSize = 16;

            public const byte MaxLength = 15;

            public static W128 W => default;

            public Cell128 Storage;

            public byte PointSize
                => 1;

            [MethodImpl(Inline)]
            internal name128(in Cell128 data)
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
                => O.format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator name128(string src)
                => F.name(W,src);

            [MethodImpl(Inline)]
            public static implicit operator name128(ReadOnlySpan<char> src)
                => F.name(W,src);

            [MethodImpl(Inline)]
            public static implicit operator name<Cell128>(name128 src)
                => new name<Cell128>(src.Storage, src.Length, src.PointSize);
        }
    }
}