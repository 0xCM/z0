//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;

    partial class Permute
    {
        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define a 4-symbol permutation
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        [MethodImpl(Inline), Op]
        public static Span<Perm4L> literals(Perm4L src)
        {            
            const int length = 4;

            Span<Perm4L> dst = new Perm4L[length];
            for(var i=0; i < length; i++)
                if(!literal(src,i, out seek(dst,i)))
                    return Span<Perm4L>.Empty;

            return dst;
        }

        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define an 8-symbol permutation to a caller-supplied target
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        /// <param name="dst">The literal receiver</param>
        [MethodImpl(Inline), Op]
        public static bit literals(Perm8L src, Span<Perm8L> dst)
        {
            const int length = 8;

            for(var i=0; i< length; i++)
                if(!literal(src, i, out seek(dst,i)))
                    return false;
            
            return true;
        }

        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define an 8-symbol permutation
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        [MethodImpl(Inline)]
        public static Span<Perm8L> literals(Perm8L src)
        {            
            const int length = 8;
            
            Span<Perm8L> dst = new Perm8L[length];
            if(!literals(src, dst))
                return Span<Perm8L>.Empty;

            return dst;
        }

        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define a 16-symbol permutation to a caller-supplied target
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        /// <param name="dst">The literal receiver</param>
        [MethodImpl(Inline), Op]
        public static bit literals(Perm16L src, Span<Perm16L> dst)
        {
            const int length = 16;

            for(var i=0; i< length; i++)
                if(!literal(src, i, out seek(dst,i)))
                    return false;
            
            return true;
        }

        /// <summary>
        /// Extracts the ordered sequence of symbolic literals that define a 16-symbol permutation to a caller-supplied target
        /// </summary>
        /// <param name="src">The canonical literal representation</param>
        [MethodImpl(Inline)]
        public static Span<Perm16L> literals(Perm16L src)
        {            
            Span<Perm16L> dst = new Perm16L[16];
            if(!literals(src,dst))
                return Span<Perm16L>.Empty;            
            return dst;
        }

        /// <summary>
        /// Enumerates all permutation map format strings on 4 symbols
        /// </summary>
        public static IEnumerable<(Perm4L perm, string format)> Exhaust(N4 n)
            => from perm in Enums.valarray<Perm4L>()
                    where !perm.IsSymbol()
                    let maps = (perm, format:perm.FormatMap())
                    orderby maps.perm descending
                    select maps;

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
        public static ReadOnlySpan<char> symbols<E,T>(T src, int segwidth, int? maxbits = null)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var index = Symbolic.index<E,T>();
            var bitcount = maxbits ?? Control.bitsize<T>();
            var count = mincells((ulong)segwidth, (ulong)bitcount);
            Span<char> symbols = new char[count];
            for(int i=0, bitpos = 0; i<count; i++, bitpos += segwidth)
            {
                var key = gbits.extract(src, (byte)bitpos, (byte)(bitpos + segwidth - 1));                
                if(index.TryGetValue(key, out var value))
                    symbols[i] = value;
                else
                    throw new Exception($"The value {key}:{typeof(T).DisplayName()} does not exist in the index");
            }
            return symbols;
        }        
    }
}