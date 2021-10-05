//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct BitStrings
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
            var seglen = (int)width<T>();
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
            => src.RemoveAny(Chars.LBracket, Chars.RBracket, Chars.Space, Chars.Underscore, (char)AsciLetterSym.b);

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
            var capacity = (int)width<T>();
            var bitseq = alloc<byte>(capacity*reps);
            var pattern = scalar(src);
            for(var i=0; i<reps; i++)
                pattern.BitSeq.CopyTo(bitseq, i*capacity);
            return load(bitseq);
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


        /// <summary>
        /// Allocates a bitstring with a specified length
        /// </summary>
        /// <param name="len">The length of the bitstring</param>
        [MethodImpl(Inline)]
        public static BitString alloc(int len)
            => new BitString(alloc<byte>(len));

        /// <summary>
        /// Loads a bitstring from a bitseq
        /// </summary>
        /// <param name="bitseq">An array containing only 0's and 1's </param>
        [MethodImpl(Inline), Op]
        public static BitString load(byte[] bitseq)
            => new BitString(bitseq);

        /// <summary>
        /// Populates a bitstring from a 128-bit cpu vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="maxbits">The maximum number of bits to extract from the source</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitString load<T>(Vector128<T> src, int? maxbits = null)
            where T : unmanaged
                => scalars(cover(gcpu.vref(ref src), cpu.vcount<T>(W128.W)), maxbits);

        /// <summary>
        /// Populates a bitstring from a 256-bit cpu vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="maxbits">The maximum number of bits to extract</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitString load<T>(Vector256<T> src, int? maxbits = null)
            where T : unmanaged
                => scalars(cover(gcpu.vref(ref src), cpu.vcount<T>(W256.W)), maxbits);

        /// <summary>
        /// Populates a bitstring from a 256-bit cpu vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="maxbits">The maximum number of bits to extract</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitString load<T>(Vector512<T> src, int? maxbits = null)
            where T : unmanaged
                => scalars(cover(gcpu.vref(ref src), cpu.vcount<T>(W512.W)), maxbits);

        /// <summary>
        /// Constructs a bitstring from primal value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static BitString scalar<T>(T src, int? maxbits = null)
            where T : unmanaged
                => new BitString(BitStringStore.bitseq(src, maxbits ?? (int)width<T>()));

        /// <summary>
        /// Constructs a bitstring from primal value, using caller-supplied storage instead of allocation
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="storage">The caller-supplied storage</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static BitString scalar<T>(T src, byte[] storage, int? maxbits = null)
            where T : unmanaged
        {
            var bitseq = BitStringStore.bitseq(src, maxbits ?? (int)width<T>());
            bitseq.CopyTo(storage);
            return new BitString(storage);
        }

        /// <summary>
        /// Converts an enumeration value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The enumeration type</typeparam>
        [MethodImpl(Inline)]
        public static BitString @enum<T>(T src, int? maxbits = null)
            where T : unmanaged, Enum
                => BitStrings.scalar((ulong)Convert.ChangeType(src, typeof(ulong)), maxbits ?? (int)width<T>());

        /// <summary>
        /// Constructs a bitstring from span of scalar values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <param name="maxbits">The maximum number of bits to extract from the source</param>
        [MethodImpl(Inline)]
        public static BitString scalars<T>(ReadOnlySpan<T> src, int? maxbits = null)
            where T : unmanaged
        {
            var cellbits = width<T>();
            var bitcount = maxbits ?? cellbits*src.Length;
            var k = 0u;
            var buffer = alloc<byte>(bitcount);
            var dst = span(buffer);

            for(int i=0; i<src.Length; i++)
            {
                var bits = BitStringStore.bitseq(skip(src,i));
                for(var j=0u; j<cellbits && k<bitcount; j++, k++)
                    seek(dst, k) = skip(bits,j);
            }
            return new BitString(buffer);
        }

        /// <summary>
        /// Constructs a bitstring from span of scalar values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="maxbits">The maximum number of bits to extract from the source</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitString scalars<T>(Span<T> src, int? maxbits = null)
            where T : unmanaged
                => scalars(src.ReadOnly(), maxbits);

        /// <summary>
        /// Constructs a bitstring from a power of 2
        /// </summary>
        /// <param name="exp">The value of the exponent</param>
        [MethodImpl(Inline)]
        public static BitString pow2(int exp)
        {
            var dst =  new byte[exp + 1];
            dst[exp] = 1;
            return load(dst);
        }

        /// <summary>
        /// Extracts a scalar value from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="offset">The bit position at which to begin extraction</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static T scalar<T>(BitString src, int offset = 0)
            where T : unmanaged
                => src.Scalar<T>(offset);

        /// <summary>
        /// Constructs a bitstring from text
        /// </summary>
        /// <param name="src">The bit source</param>
        public static BitString parse(string src)
        {
            src = src.RemoveBlanks();
            var len = src.Length;
            var lastix = len - 1;
            Span<byte> dst = core.alloc<byte>(len);
            for(var i=0; i<= lastix; i++)
                dst[lastix - i] = src[i] == bit.Zero ? (byte)0 : (byte)1;
            return new BitString(dst);
        }

        /// <summary>
        /// Computes the bitwise complement of the source operand
        /// </summary>
        /// <param name="src">The source bits</param>
        public static BitString not(BitString src)
        {
            var len = src.Length;
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = ~src[i];
            return dst;
        }

        static int length(BitString a, BitString b)
        {
            var len = a.Length;
            return len == b.Length ? len : throw new Exception($"Length mismatch: {a.Length} != {b.Length}");
        }

        /// <summary>
        /// Computes the bitwise and between the operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        public static BitString and(BitString a, BitString b)
        {
            var len = length(a, b);
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = a[i] & b[i];
            return dst;
        }

        /// <summary>
        /// Computes the bitwise or between the operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        public static BitString or(BitString a, BitString b)
        {
            var len = length(a, b);
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = a[i] | b[i];
            return dst;
        }

        /// <summary>
        /// Computes the bitwise xor between the operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        public static BitString xor(BitString a, BitString b)
        {
            var len = length(a,b);
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = a[i] ^ b[i];
            return dst;
        }

        /// <summary>
        /// Applies a logical right-shift to the source
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="shift">The shift offset</param>
        public static BitString srl(BitString src, int shift)
        {
            var dst = alloc(src.Length);
            for(var i=src.Length - shift; i>=0; i--)
                dst[i] = src[i];
            return dst;
        }

        /// <summary>
        /// Applies a logical left-shift to the source
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="shift">The shift offset</param>
        public static BitString sll(BitString src, int shift)
        {
            var dst = alloc(src.Length);
            for(var i=shift; i<dst.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        /// <summary>
        /// Extracts the even bits from the source
        /// </summary>
        public static BitString even(BitString src)
        {
            var count = src.Length>>1;
            var dst = alloc(count);
            for(int i=0,j=0; i<src.Length; i+=2,j++)
                dst[j] = src[i];
            return dst;
        }

        /// <summary>
        /// Extracts the odd bits from the source
        /// </summary>
        public static BitString odd(BitString src)
        {
            var count = src.Length>>1;
            var dst = alloc(count);
            for(int i=1,j=0; i<src.Length; i+=2,j++)
                dst[j] = src[i];
            return dst;
        }

        /// <summary>
        /// Considers the source bitstring as a row-major encoding of an mxn matrix and computes
        /// the transposition maxtrix of dimension nxm similary encoded as a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="m">The source row count</param>
        /// <param name="n">The source column count</param>
        public static BitString transpose(BitString src, int m, int n)
        {
            var bitcount = m*n;
            if(src.Length < bitcount)
                return BitString.Empty;

            var k = 0;
            var dst = alloc(bitcount);
            for(var colidx = 0; colidx < n; colidx++)
            for(int j=colidx; j<bitcount; j+=n, k++)
                dst[k] = src[j];

            return dst;
        }

        public static BitString transpose(BitString src, ulong m, ulong n)
            => transpose(src,(int)m, (int)n);

        /// <summary>
        /// Overwrites selected target bits with lower bits from the source
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <param name="start">The target index at which to begin</param>
        /// <param name="len">The number of bits to overwrite</param>
        public static BitString inject(BitString src, BitString dst, int start, int len)
        {
            for(int i=start, j=0; i<start + len; i++, j++)
                dst[i] = src[j];
            return dst;
        }

        /// <summary>
        /// Intersperses the source bitstring with content from another
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="value">The interspersal value</param>
        public static BitString intersperse(BitString src, BitString value)
        {
            var len = Math.Min(src.Length, value.Length);
            var dst = alloc(len*2);
            for(int i=0, j=0; i< dst.Length; i+=2, j++)
            {
                dst[i] = src[j];

                if(i+1 < dst.Length)
                    dst[i+1] = value[j];
            }
            return dst;
        }

        /// <summary>
        /// Clears a contiguous sequence of bits between two indices
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="i0">The index of the first bit to clear</param>
        /// <param name="i1">The index of the last bit to clear</param>
        public static BitString clear(BitString src, int i0, int i1)
        {
            for(var i=i0; i<=i1; i++)
                src[i] = bit.Off;
            return src;
        }

        /// <summary>
        /// Rotates the bits leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        public static BitString rotl(BitString bs, uint offset)
        {
            var dst = bs.Data.Replicate();
            var shift = (int)offset;
            Span<byte> src = stackalloc byte[bs.Length];
            dst.CopyTo(src);
            var cut = bs.Length - shift;
            var seg1 = src.Slice(0, cut);
            var seg2 = src.Slice(cut);
            seg2.CopyTo(dst, 0);
            seg1.CopyTo(dst, shift);
            return load(dst);
        }

        /// <summary>
        /// Enables a specified source bit
        /// </summary>
        /// <param name="src">The source value to manipulate</param>
        /// <param name="pos">The position of the bit to enable</param>
        [MethodImpl(Inline)]
        static byte enable(byte src, int pos)
            =>  src |= (byte)(1 << pos);

        internal static Span<byte> pack(ReadOnlySpan<byte> src, int offset = 0, int? minlen = null)
        {
            if(src.Length <= offset)
                return new byte[minlen ?? 1];

            var srcLen = (uint)(src.Length - offset);
            var dstLen = srcLen/8 + (srcLen % 8 == 0 ? 0 : 1);
            if(minlen != null && dstLen < minlen)
                dstLen = minlen.Value;

            Span<byte> dst = core.alloc<byte>((int)dstLen);
            for(int i=0, j=0; j < dstLen; i+=8, j++)
            {
                ref var x = ref dst[j];
                for(var k=0; k<8; k++)
                {
                    var srcIx = i + k + offset;
                    if(srcIx < srcLen && src[srcIx] != 0)
                        x = enable(x, k);
                }
            }
            return dst;
        }

    }
}