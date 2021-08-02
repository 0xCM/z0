//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BZ
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = Blit;

    public readonly struct name<T> : IName<name<T>,T>
        where T : unmanaged
    {
        public static uint MaxLength(byte psz) => size<T>()*psz - 1;

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

        [MethodImpl(Inline)]
        public static implicit operator name64(string src)
            => api.name(W,src);

        [MethodImpl(Inline)]
        public static implicit operator name64(ReadOnlySpan<char> src)
            => api.name(W,src);

        [MethodImpl(Inline)]
        public static implicit operator name<ulong>(name64 src)
            => new name<ulong>(src.Storage, src.Length, src.PointSize);
    }

    public struct name128 : IName<name128,Cell128>
    {
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

        [MethodImpl(Inline)]
        public static implicit operator name128(string src)
            => api.name(W,src);

        [MethodImpl(Inline)]
        public static implicit operator name128(ReadOnlySpan<char> src)
            => api.name(W,src);

        [MethodImpl(Inline)]
        public static implicit operator name<Cell128>(name128 src)
            => new name<Cell128>(src.Storage, src.Length, src.PointSize);
    }
}