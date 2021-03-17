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
            dst[i++] = PermSymbolic.letter(n4, src[j++], src[j++]);
            dst[i++] = PermSymbolic.letter(n4, src[j++], src[j++]);
            dst[i++] = PermSymbolic.letter(n4, src[j++], src[j++]);
            dst[i++] = PermSymbolic.letter(n4, src[j++], src[j++]);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static char letter(N4 n, bit x, bit y)
        {
            if(x && y)
                return 'D';
            else if(!x && !y)
                return 'A';
            else if(x && !y)
                return 'B';
            else
                return 'C';
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
            var values = Enums.dictionary<E,T>();
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
                var key = gbits.segment(src, (byte)bitpos, (byte)(bitpos + segwidth - 1));
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

    partial class XTend
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