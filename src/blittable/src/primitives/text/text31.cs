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
    using static BitFlow;

    public struct text31 : IName<text31,ByteBlock32>
    {
        public const byte MaxLength = 31;

        static N31 N => default;

        public ByteBlock32 Storage;

        public byte PointSize
            => 1;

        [MethodImpl(Inline)]
        internal text31(in ByteBlock32 data)
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
            get => Storage[31];
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Storage.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Storage.IsNonEmpty;
        }

        public string Format()
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator text31(string src)
            => txt(N,src);

        [MethodImpl(Inline)]
        public static implicit operator text31(ReadOnlySpan<char> src)
            => txt(N,src);

        public static text31 Empty => default;
    }

    partial struct BitFlow
    {
        [MethodImpl(Inline), Op]
        public static text31 txt(N31 n, ReadOnlySpan<char> src)
        {
            const byte Max = text31.MaxLength;
            var length = (byte)min(available(src), Max);
            var storage = ByteBlock32.Empty;
            var dst = storage.Bytes;
            pack(src, length, dst);
            seek(dst,31) = length;
            return new text31(storage);
        }

        [Op]
        public static string format(in text31 src)
        {
            Span<char> dst = stackalloc char[text31.MaxLength];
            var count = src.Length;
            var data = src.Bytes;
            for(var i=0; i<count; i++)
                seek(dst,i) = (char)skip(data,i);
            return text.format(slice(dst,0,count));
        }
    }
}