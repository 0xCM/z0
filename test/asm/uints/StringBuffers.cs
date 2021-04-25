//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    unsafe readonly struct ResBuffer
    {
        const string Storage = "A null argument was provided                                                                                                                                                                ";

        static Span<char> Buffer
        {
            [MethodImpl(Inline)]
            get => memory.edit(text.span(Storage));
        }

        public static uint Capacity
        {
            [MethodImpl(Inline)]
            get => (uint)Buffer.Length;
        }

        const string Part0 = "A null argument was provided";

        const string Part1 = ": ";

        const string Part2 = "TName";

        [MethodImpl(Inline)]
        public static string format()
        {
            var dst = Buffer;

            var seg0 = chars(Part0);
            var seg1 = chars(Part1);
            var seg2 = chars(Part2);

            var n0 = (uint)seg0.Length;
            var n1 = (uint)seg1.Length;
            var n2 = (uint)seg2.Length;
            var n = n0 + n1 + n2;
            var last = Math.Min(n, Capacity);

            for(uint i=0u, j=0u; i<n0; i++, j++)
                seek(dst, i) = skip(seg0, j);

            for(uint i=n0, j=0; i<n1; i++, j++)
                seek(dst, i) = skip(seg1, j);

            for(uint i=n2, j=0; i<last; i++, j++)
                seek(dst, i) = skip(seg2, j);

            seek(dst,last) = (char)0;

            return Storage;
        }

        [MethodImpl(Inline)]
        public static string format<T>()
        {
            var dst = memory.edit(chars(Storage));
            var name = chars(typeof(T).Name);
            var first = (uint)Part0.Length;
            var last = Math.Min(first + (uint)name.Length,Storage.Length);

            for(uint i=first, j=0; i<last; i++, j++)
                seek(dst,i) = skip(name,j);

            return Storage;
        }

        [MethodImpl(Inline)]
        public static string format<T>(string caller, string file, int? line)
        {
            return Part0;
        }

        public const string MsgText = "A null argument was provided";
    }

}