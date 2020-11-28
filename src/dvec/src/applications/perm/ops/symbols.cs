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
    using System.Runtime.Intrinsics;

    using static Konst;
    using static BitMasks.Literals;
    using static z;

    partial class Permute
    {
        /// <summary>
        /// Creates a fixed 16-bit permutation over a generic permutation over 16 elements
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline), Op]
        public static Perm16 vinit(W128 w, Perm<byte> spec)
            => new Perm16(z.vload(w128, spec.Terms));

        /// <summary>
        /// Creates a fixed 32-bit permutation over a generic permutation over 32 elements
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline), Op]
        public static Perm32 vinit(W256 w, Perm<byte> src)
            => new Perm32(z.vload(w, src.Terms));

        [MethodImpl(Inline), Op]
        public static Perm16 vspec(Vector128<byte> data)
            => new Perm16(z.vand(data, z.vbroadcast(w128, Msb8x8x3)));

        [MethodImpl(Inline), Op]
        public static Perm32 vspec(Vector256<byte> data)
            => new Perm32(z.vand(data, z.vbroadcast(w256, Msb8x8x3)));

        /// <summary>
        /// Enumerates all permutation map format strings on 4 symbols
        /// </summary>
        public static IEnumerable<(Perm4L perm, string format)> symbols(N4 n)
            => from perm in Enums.literals<Perm4L>()
                    where !PermSymbolic.test(perm)
                    let maps = (perm, format:perm.FormatMap())
                    orderby maps.perm descending
                    select maps;

        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> symbols(Perm2x4 src)
            => symbols<Perm4Sym,byte>((byte)src, 4, bitwidth<byte>());

        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> symbols(Perm4L src)
            => symbols<Perm4Sym,byte>((byte)src, 2, bitwidth<byte>());

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
            => symbols<Perm16L,ulong>((ulong)src, 4, bitwidth<ulong>());

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
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> symbols<E,T>(T src, uint segwidth, uint maxbits)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var index = Symbolic.index<E,T>();
            var count = mincells((ulong)segwidth, (ulong)maxbits);
            Span<char> symbols = new char[count];
            for(uint i=0, bitpos = 0; i<count; i++, bitpos += segwidth)
            {
                var key = gbits.extract(src, (byte)bitpos, (byte)(bitpos + segwidth - 1));
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

        [MethodImpl(Inline), Op]
        public static Vector128<byte> shuffles(NatPerm<N16> src)
            => z.vload(n128, first(z.transform<byte>(src.Terms)));

        /// <summary>
        /// Shuffles the permutation in-place using a provided random source.
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static ref readonly Perm shuffle(in Perm src, IPolyStream random)
        {
            random.Shuffle(src.Terms);
            return ref src;
        }

        /// <summary>
        /// Shuffles the permutation in-place using a provided random source.
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static ref readonly Perm<T> shuffle<T>(in Perm<T> src, IPolyStream random)
            where T : unmanaged
        {
            random.Shuffle(src.Terms);
            return ref src;
        }
    }
}