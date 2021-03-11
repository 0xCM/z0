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

    partial struct BitString
    {
        /// <summary>
        /// Constructs a bitsequence via the bitstore and populates an allocated target with the result
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> storeseq<T>(T src)
            where T : unmanaged
                => BitStringStore.bitseq(src);

        /// <summary>
        /// Constructs a sequence of n characters {ci} := [c_n-1,..., c_0]
        /// over the domain {'0','1'} according to whether the bit in the i'th
        /// position of the source is respectively disabled/enabled
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void bitchars<T>(T src, Span<char> dst, int offset = 0)
            where T : unmanaged
                => BitStringStore.bitchars(src,dst,offset);

        /// <summary>
        /// Constructs a sequence of n characters {ci} := [c_n-1,..., c_0]
        /// over the domain {'0','1'} according to whether the bit in the i'th
        /// position of the source is respectively disabled/enabled
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<char> bitchars<T>(in T src)
            where T : unmanaged
        {
            var dst = sys.alloc<char>(width<T>());
            bitchars(src, dst);
            return dst;
        }

        /// <summary>
        /// Converts a span of primal values to a span of characters, each of which represent a bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<char> bitchars<T>(ReadOnlySpan<T> src, int? maxlen = null)
            where T : unmanaged
        {
            var seglen = width<T>();
            var srclen = src.Length;
            Span<char> dst = sys.alloc<char>(srclen * seglen);
            ref readonly var input = ref first(src);

            for(var i=0; i<srclen; i++)
                bitchars(skip(input,i)).CopyTo(dst, i*seglen);
            return maxlen != null && dst.Length >= maxlen ?  dst.Slice(0,maxlen.Value) :  dst;
        }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<char> bitchars<T>(Span<T> src, int? maxlen = null)
            where T : unmanaged
                => bitchars(src.ReadOnly(), maxlen);

        /// <summary>
        /// Removes characters related to formating/presentation that do not impact the value of the bitstring literal;
        /// leading zeroes, however, are considered part of the literal and are not removed
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static string normalize(string src)
            => src.RemoveAny(Chars.LBracket, Chars.RBracket, Chars.Space, Chars.Underscore, (char)AsciLetter.b);

        /// <summary>
        /// Assembles a bitstring given parts ordered from lo to hi
        /// </summary>
        /// <param name="parts">The source parts</param>
        [MethodImpl(Inline)]
        public static BitString assemble(params string[] parts)
            => parse(string.Join(string.Empty, parts.Reverse()));

        /// <summary>
        /// Constructs a bitstring from a pattern replicated a specified number of times
        /// </summary>
        /// <param name="src">The source pattern</param>
        /// <param name="reps">The number of times to repeat the pattern</param>
        /// <typeparam name="T">The primal source type</typeparam>
        public static BitString replicate<T>(T src, int reps)
            where T : unmanaged
        {
            var capacity = width<T>();
            var bitseq = sys.alloc<byte>(capacity*reps);
            var pattern = scalar(src);
            for(var i=0; i<reps; i++)
                pattern.BitSeq.CopyTo(bitseq, i*capacity);
            return BitString.load(bitseq);
        }

        /// <summary>
        /// Projects a bitstring onto a caller-allocated span via a supplied transformation
        /// </summary>
        /// <param name="f">The transformation</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]
        public static void map<T>(BitString src, Func<bit,T> f, Span<T> dst)
        {
            for(var i=0; i<dst.Length; i++)
                dst[i] = f((bit)src.Data[i]);
        }
    }
}