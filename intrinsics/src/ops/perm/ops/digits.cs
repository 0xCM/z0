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

    partial class Perm
    {
        public static IDictionary<T,char> symindex<E,T>()
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
        /// <typeparam name="T">The primal bitvector cell type</typeparam>
        public static ReadOnlySpan<char> symbols<E,T>(T src, int segwidth, int? maxbits = null)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var index = symindex<E,T>();
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
        /// Computes the digigs corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatBlock<N4, byte> digits(Perm4L src)
        {
            var scalar = (byte)src;
            var dst = DataBlocks.natalloc<N4,byte>();
            dst[0] = BitMask.between(scalar, 0, 1);
            dst[1] = BitMask.between(scalar, 2, 3);
            dst[2] = BitMask.between(scalar, 4, 5);
            dst[3] = BitMask.between(scalar, 6, 7);
            return dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 3-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatBlock<N8, OctalDigit> digits(Perm8L src)
        {
            //[0 1 2 | 3 4 5 | 6 7 8 | ... | 21 22 23] -> 256x32
            var scalar = (uint)src;
            var dst = DataBlocks.natalloc<N8,OctalDigit>();
            dst[0] = (OctalDigit)BitMask.between(scalar, 0, 2);
            dst[1] = (OctalDigit)BitMask.between(scalar, 3, 5);
            dst[2] = (OctalDigit)BitMask.between(scalar, 6, 8);
            dst[3] = (OctalDigit)BitMask.between(scalar, 9, 11);
            dst[4] = (OctalDigit)BitMask.between(scalar, 12, 14);
            dst[5] = (OctalDigit)BitMask.between(scalar, 15, 17);
            dst[6] = (OctalDigit)BitMask.between(scalar, 18, 20);
            dst[7] = (OctalDigit)BitMask.between(scalar, 21, 23);
            return dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatBlock<N16, HexDigit> digits(Perm16L src)
        {
            var scalar = (ulong)src;
            var dst = DataBlocks.natalloc<N16,HexDigit>();
            dst[0] = (HexDigit)BitMask.between(scalar, 0, 3);
            dst[1] = (HexDigit)BitMask.between(scalar, 4, 7);
            dst[2] = (HexDigit)BitMask.between(scalar, 8, 11);
            dst[3] = (HexDigit)BitMask.between(scalar, 12, 15);
            dst[4] = (HexDigit)BitMask.between(scalar, 16, 19);
            dst[5] = (HexDigit)BitMask.between(scalar, 20, 23);
            dst[6] = (HexDigit)BitMask.between(scalar, 24, 27);
            dst[7] = (HexDigit)BitMask.between(scalar, 28, 31);
            dst[8] = (HexDigit)BitMask.between(scalar, 32, 35);
            dst[9] = (HexDigit)BitMask.between(scalar, 36, 39);
            dst[10] = (HexDigit)BitMask.between(scalar, 40, 43);
            dst[11] = (HexDigit)BitMask.between(scalar, 44, 47);
            dst[12] = (HexDigit)BitMask.between(scalar, 48, 53);
            dst[13] = (HexDigit)BitMask.between(scalar, 52, 55);
            dst[14] = (HexDigit)BitMask.between(scalar, 56, 59);
            dst[15] = (HexDigit)BitMask.between(scalar, 60, 63);
            return dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec as
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> digits(Perm16Spec spec)
            => dinx.vshuf16x8(vbuild.increments<byte>(n128), spec.data);

        /// <summary>
        /// Computes the digits corresponding to each 5-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> digits(Perm32Spec spec)
            => dinx.vshuf32x8(vbuild.increments<byte>(n256),spec.data);

        /// <summary>
        /// Deconstructs a permutation literal into an odered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> symbols(Perm4L src)
            => Perm.symbols<Perm4Sym,byte>((byte)src,2);

        /// <summary>
        /// Deconstructs a permutation literal into an odered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> symbols(Perm8L src)
            => Perm.symbols<Perm8Sym,uint>((uint)src,3,24);

        /// <summary>
        /// Deconstructs a permutation literal into an odered sequence of symbols that define the permutation
        /// </summary>
        /// <param name="src">The perm literal</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> symbols(Perm16L src)
            => Perm.symbols<Perm16Sym,ulong>((ulong)src,4);
    }
}