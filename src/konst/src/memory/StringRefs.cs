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

    [ApiHost(ApiNames.StringRefs, true)]
    public readonly partial struct StringRefs
    {
        /// <summary>
        /// Creates a <see cref='StringRef'/> from a specified <see cref='string'/> and optional user data
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="user">The user data, if any</param>
        [MethodImpl(Inline), Op]
        public static unsafe StringRef @string(string src, uint user = 0)
            => new StringRef((ulong)pchar2(src), (uint)src.Length, user);

        /// <summary>
        /// Creates a <see cref='StringRef'/> from a specified <see cref='MemoryAddress'/> and memory size
        /// </summary>
        /// <param name="address">The reference address</param>
        /// <param name="length">The size, in bytes, of the segment</param>
        [MethodImpl(Inline)]
        public static StringRef define(MemoryAddress address, uint length)
            => new StringRef(address, length);

        /// <summary>
        /// Creates a <see cref='StringRef'/> from a specified <see cref='SegRef'/>
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static StringRef @string(SegRef src)
            => new StringRef(vparts(N128.N, src.Address, (ulong)src.DataSize));

        /// <summary>
        /// Creates a <see cref='StringRef'/> from a specified <see cref='Ref'/>
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static StringRef @string(Ref src)
            => new StringRef(vparts(N128.N, src.Location, (ulong)src.DataSize));

        [MethodImpl(Inline), Op]
        public static unsafe StringRef @ref(string src)
            => new StringRef((ulong)pchar(src), (uint)src.Length);

        [MethodImpl(Inline), Op]
        public StringRefs<N4> refs(string s0, string s1, string s2, string s3)
            => refs(default(N4), @ref(s0), @ref(s1), @ref(s2), @ref(s3));

        [MethodImpl(Inline)]
        public static StringRefs<N> refs<N>(N n, params StringRef[] src)
            where N : unmanaged, ITypeNat
                => new StringRefs<N>(src);

        [MethodImpl(Inline), Op]
        public static void refs(ReadOnlySpan<string> src, Span<StringRef> dst)
        {
            for(var i=0u; i<src.Length; i++)
                seek(dst,i) = StringRefs.@ref(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static StringRef[] refs(ReadOnlySpan<string> src)
        {
            var dst = sys.alloc<StringRef>(src.Length);
            refs(src,dst);
            return dst;
        }

        /// <summary>
        /// Computes the number of characters represented by a <see cref='StringRef'/>
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static uint length(StringRef src)
            => (uint)(hi(src)/scale<char>());

        [MethodImpl(Inline), Op]
        static ulong lo(StringRef src)
            => z.vcell(src.Data, 0);

        [MethodImpl(Inline), Op]
        static ulong hi(StringRef src)
            => z.vcell(src.Data, 1);

        [MethodImpl(Inline), Op]
        public static unsafe string format(StringRef src)
            => sys.@string(src.Address.Pointer<char>());

        public static string join(string delimiter, params StringRef[] refs)
        {
            var dst = text.build();
            var src = span(refs);
            var count = src.Length;

            for(var i=0u; i<count; i++)
            {
                var s = z.skip(src,i).Text;
                dst.Append(s);
                if(i != count - 1)
                    dst.Append(delimiter);
            }

            return dst.ToString();
        }
    }
}