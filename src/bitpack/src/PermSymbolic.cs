//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct PermSymbolic
    {
        [Op]
        public static ReadOnlySpan<char> bitblock(Perm4L src, bool bracketed = true)
        {
            var storage = 0ul;
            var bits8u = cover(@as<byte>(storage),8);
            BitPack.unpack1x8((byte)src, bits8u);
            var bits = recover<bit>(bits8u);
            var chars = CharBlocks.alloc(n16).Data;
            var i=0;
            var j=0;

            if(bracketed)
                seek(chars,i++) = Chars.LBracket;

            seek(chars,i++) = skip(bits,j + 1).ToChar();
            seek(chars,i++) = skip(bits,j + 0).ToChar();
            seek(chars,i++) = Chars.Space;

            seek(chars,i++) = skip(bits,j + 3).ToChar();
            seek(chars,i++) = skip(bits,j + 2).ToChar();

            seek(chars,i++) = Chars.Space;
            seek(chars,i++) = skip(bits,j + 5).ToChar();
            seek(chars,i++) = skip(bits,j + 4).ToChar();

            seek(chars,i++) = Chars.Space;
            seek(chars,i++) = skip(bits,j + 7).ToChar();
            seek(chars,i++) = skip(bits,j + 6).ToChar();

            if(bracketed)
                seek(chars,i++) = Chars.RBracket;

            return slice(chars,0,i);
        }

        /// <summary>
        /// Formats the value as a permutation map, i.e., [00 01 10 11]: ABCD -> ABDC
        /// </summary>
        /// <param name="src">The permutation spec</param>
        [Op]
        public static string bitmap(Perm4L src)
        {
            const string Domain ="ABCD";
            const string Pattern = "{0}: {1} -> {2}";
            const byte BitCount = 8;

            var n = n4;
            var storage = 0ul;
            var bitbuffer = cover(@as<byte>(storage),BitCount);
            BitPack.unpack1x8((byte)src, bitbuffer);
            var bits = recover<bit>(bitbuffer);
            var block = bitblock(src,true);
            var codomain = CharBlocks.alloc(n).Data;
            letters(n, @readonly(bits), codomain);
            return string.Format(Pattern, text.format(block), Domain, text.format(codomain));
        }

        [MethodImpl(Inline), Op]
        public static void letters(N4 n, ReadOnlySpan<bit> src, Span<char> dst)
        {
            int i=0, j=0;
            seek(dst,i++) = letter(n4, skip(src,j++), skip(src,j++));
            seek(dst,i++) = letter(n4, skip(src,j++), skip(src,j++));
            seek(dst,i++) = letter(n4, skip(src,j++), skip(src,j++));
            seek(dst,i++) = letter(n4, skip(src,j++), skip(src,j++));
        }

        public static string fPerm2x128<T>(Vector512<T> src, Perm2x4 p0, Perm2x4 p1)
            where T : unmanaged
        {
            var sfk = SequenceFormatKind.List;
            var sep = Chars.Comma;
            var pad = 2;
            var sym0 = PermSymbolic.symbols(p0).ToString();
            var sym1 = PermSymbolic.symbols(p1).ToString();
            return $"{src.Format()} |> {sym0}{sym1} = {gcpu.vperm2x128(src, p0, p1).Format()}";
        }

        [MethodImpl(Inline), Op]
        public static Span<char> letters(N4 n, BitSpan src, Span<char> dst)
        {
            int i=0, j=0;
            seek(dst,i++) = letter(n4, src[j++], src[j++]);
            seek(dst,i++) = letter(n4, src[j++], src[j++]);
            seek(dst,i++) = letter(n4, src[j++], src[j++]);
            seek(dst,i++) = letter(n4, src[j++], src[j++]);
            return dst;
        }

        static ReadOnlySpan<AsciCharCode> Perm4Codes
            => new AsciCharCode[4]{AsciCharCode.A, AsciCharCode.B, AsciCharCode.C, AsciCharCode.D,};

        [MethodImpl(Inline), Op]
        public static char letter(N4 n, bit x, bit y)
        {
            var index = Bytes.or(Bytes.sll((byte)y,1) , (byte)x);
            return (char)skip(Perm4Codes, index);
        }

        /// <summary>
        /// Creates value-to-symbol index
        /// </summary>
        /// <typeparam name="E">The enumeration type that defines the symbols</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        static IDictionary<T,char> lookup<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var values = ClrEnums.dictionary<E,T>();
            var index = new Dictionary<T,char>();
            foreach(var kvp in values)
                index[kvp.Key] = kvp.Value.ToString().Last();
            return index;
        }

        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> symbols(Perm2x4 src)
            => symbols<Perm4Sym,byte>((byte)src, 4, memory.width<byte>());

        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> symbols(Perm4L src)
            => symbols<Perm4Sym,byte>((byte)src, 2, memory.width<byte>());

        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> symbols(Perm8L src)
            => symbols<Perm8Sym,uint>((uint)src, 3, 24);

        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> symbols(Perm16L src)
            => symbols<Perm16L,ulong>((ulong)src, 4, memory.width<ulong>());

        /// <summary>
        /// Computes the minimum number of cells required to store a specified number of bits
        /// </summary>
        /// <param name="w">The cell width</param>
        /// <param name="n">The bit count/number of matrix columns</param>
        [MethodImpl(Inline), Op]
        static int mincells(ulong w, ulong n)
        {
            // if a single cell covers a column then there's no need for computation
            if(w >= n)
                return 1;

            var q = n / w;
            var r = n % w;
            return (int)(r == 0 ? q : q + 1);
        }

        /// <summary>
        /// Assumes that
        /// 1. The source data source is a tape upon which fixed-width symbols are sequentially recorded
        /// 2. The symbol alphabet is defined by the last character of the literals defined by an enumeration
        /// With these preconditions, the operation returns the ordered sequence of symbols written to the tape
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="segwidth">The number of bits designated to represent/define a symbol value</param>
        /// <param name="maxbits">The maximum number bits to use if less than the bit width of the vector</param>
        /// <typeparam name="E">The enumeration type that defines the symbols</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static ReadOnlySpan<char> symbols<E,T>(T src, uint segwidth, uint maxbits)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var index = lookup<E,T>();
            var count = mincells((ulong)segwidth, (ulong)maxbits);
            Span<char> symbols = new char[count];
            for(uint i=0, bitpos = 0; i<count; i++, bitpos += segwidth)
            {
                var key = gbits.bitseg(src, (byte)bitpos, (byte)(bitpos + segwidth - 1));
                if(index.TryGetValue(key, out var value))
                    seek(symbols,i) = value;
                else
                    ThrowKeyNotFound(key);
            }
            return symbols;
        }

        static void ThrowKeyNotFound<T>(T key)
            where T : unmanaged
                => throw new Exception($"The value {key}:{typeof(T).DisplayName()} does not exist in the index");
    }

    public static partial class XTend
    {
        /// <summary>
        /// Formats a permutation literal as one would hope
        /// </summary>
        /// <param name="src">The literal definition</param>
        public static string Format(this Perm4L src)
            => PermSymbolic.symbols(src).ToString();

        /// <summary>
        /// Formats a permutation literal as one would hope
        /// </summary>
        /// <param name="src">The literal definition</param>
        public static string Format(this Perm8L src)
            => PermSymbolic.symbols(src).ToString();

        /// <summary>
        /// Formats a permutation literal as one would hope
        /// </summary>
        /// <param name="src">The literal definition</param>
        public static string Format(this Perm16L src)
            => PermSymbolic.symbols(src).ToString();
    }
}