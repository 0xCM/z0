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

    partial struct BitFlow
    {
        [MethodImpl(Inline), Op]
        public static text15 txt(N15 n, ReadOnlySpan<char> src)
        {
            const byte Max = text15.MaxLength;
            var length = (byte)min(available(src), Max);
            var storage = Cell128.Empty;
            var dst = storage.Bytes;
            pack(src, length, dst);
            seek(dst,15) = length;
            return new text15(storage);
        }

        [MethodImpl(Inline), Op]
        static uint available(ReadOnlySpan<char> src)
        {
            var present = 0u;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                if(skip(src,i) != 0)
                    present++;
                else
                    break;
            }
            return present;
        }

        [MethodImpl(Inline), Op]
        static void pack(ReadOnlySpan<char> src, uint count, Span<byte> dst)
        {
            for(var i=0; i<count; i++)
                seek(dst,i) = (byte)skip(src,i);
        }

        [Op]
        public static string format(in text15 src)
        {
            Span<char> dst = stackalloc char[text15.MaxLength];
            var count = src.Length;
            var data = src.Bytes;
            for(var i=0; i<count; i++)
                seek(dst,i) = (char)skip(data,i);
            return text.format(slice(dst,0,count));
        }
    }
    public struct text15 : IName<text15,Cell128>
    {
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
        public static implicit operator text15(string src)
            => txt(N,src);

        [MethodImpl(Inline)]
        public static implicit operator text15(ReadOnlySpan<char> src)
            => txt(N,src);

        public static text15 Empty => default;
    }
}