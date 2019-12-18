//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;    

    partial class Perms
    {
        /// <summary>
        /// Creates value-to-symbol index
        /// </summary>
        /// <typeparam name="E">The enumeration type that defines the symbols</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static IDictionary<T,char> indexsymbols<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var values = Enums.values<E,T>();
            var index = new Dictionary<T,char>();
            foreach(var kvp in values)
                index[kvp.Key] = kvp.Value.ToString().Last();
            return index;
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
            var index = indexsymbols<E,T>();
            var bitcount = maxbits ?? bitsize<T>();
            var count = BitCalcs.mincells(segwidth, bitcount);
            Span<char> symbols = new char[count];
            for(int i=0, bitpos = 0; i<count; i++, bitpos += segwidth)
            {
                var key = BitMask.between(src, bitpos, bitpos + segwidth - 1);                
                if(index.TryGetValue(key, out var value))
                    symbols[i] = value;
                else
                    throw new Exception($"The value {key}:{typename<T>()} does not exist in the index");
            }
            return symbols;
        }

        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> symbols(Perm4L src)
            => Perms.symbols<Perm4Sym,byte>((byte)src,2);

        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> symbols(Perm8L src)
            => Perms.symbols<Perm8Sym,uint>((uint)src,3,24);

        /// <summary>
        /// Deconstructs a permutation literal into an ordered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> symbols(Perm16L src)
            => Perms.symbols<Perm16Sym,ulong>((ulong)src,4);
    }
}