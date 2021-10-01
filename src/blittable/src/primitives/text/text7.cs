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

    public struct text7 : IName<text7,ulong>
    {
        public const byte MaxLength = 7;

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
            get => (uint)(Storage >> 56) & 0xFF;
        }

        public string Format()
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(text7 src)
            => eq(this,src);

        public override bool Equals(object src)
            => src is text7 n ? Equals(n) : false;

        public override int GetHashCode()
            => (int)hash(this);

        [MethodImpl(Inline)]
        public static bool operator ==(text7 a, text7 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(text7 a, text7 b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator text7(string src)
            => txt(N,src);

        [MethodImpl(Inline)]
        public static implicit operator text7(ReadOnlySpan<char> src)
            => txt(N,src);

        [MethodImpl(Inline)]
        public static implicit operator text7(char src)
            => txt(N,src);

        public static text7 Empty => default;
    }

    partial struct BitFlow
    {
        [MethodImpl(Inline), Op]
        public static uint hash(text7 src)
            => alg.hash.calc(src.Storage);

        [Op]
        public static string format(in text7 src)
        {
            Span<char> dst = stackalloc char[text7.MaxLength];
            var count = src.Length;
            var data = src.Bytes;
            for(var i=0; i<count; i++)
                seek(dst, i) = (char)skip(data,i);
            return text.format(slice(dst,0,count));
        }

        [MethodImpl(Inline), Op]
        public static text7 txt(N7 n, ReadOnlySpan<char> src)
        {
            const byte Max = text7.MaxLength;
            var length = (byte)min(available(src), Max);
            var storage = 0ul;
            var dst = bytes(storage);
            pack(src, length, dst);
            seek(dst,7) = length;
            return new text7(storage);
        }

        [MethodImpl(Inline), Op]
        public static text7 txt(N7 n7, char src)
        {
            var storage = (ulong)src;
            return new text7(storage);
        }

        [MethodImpl(Inline), Op]
        public static bit eq(text7 a, text7 b)
            => a.Storage == b.Storage;

        [MethodImpl(Inline), Op]
        public static bit neq(text7 a, text7 b)
            => a.Storage != b.Storage;

   }
}