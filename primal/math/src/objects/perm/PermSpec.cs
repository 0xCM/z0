//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    public static class PermSpec
    {
        /// <summary>
        /// Constructs a permutation of length four from four symbols
        /// </summary>
        /// <param name="x0">The symbol in the first position</param>
        /// <param name="x1">The symbol in the second position</param>
        /// <param name="x2">The symbol in the third position</param>
        /// <param name="x3">The symbol in the fourth position</param>
        [MethodImpl(Inline)]
        public static Perm4 assemble(Perm4 x0, Perm4 x1, Perm4 x2, Perm4 x3)
        {               
            var dst = 0u;
            dst |= (uint)x0;
            dst |= (uint)x1 << 2;
            dst |= (uint)x2 << 4;
            dst |= (uint)x3 << 6;
            return (Perm4)dst;
        }

        [MethodImpl(Inline)]
        public static Perm16 assemble(
            Perm16 x0, Perm16 x1, Perm16 x2, Perm16 x3, 
            Perm16 x4, Perm16 x5, Perm16 x6, Perm16 x7, 
            Perm16 x8, Perm16 x9, Perm16 xA, Perm16 xB, 
            Perm16 xC, Perm16 xD, Perm16 xE, Perm16 xF) 
        {               
            var dst = 
                  (ulong)x0       | (ulong)x1 << 4  | (ulong)x2 << 8  | (ulong)x3 << 12 
                | (ulong)x4 << 16 | (ulong)x5 << 20 | (ulong)x6 << 24 | (ulong)x7 << 28 
                | (ulong)x8 << 32 | (ulong)x9 << 36 | (ulong)xA << 40 | (ulong)xB << 44 
                | (ulong)xC << 48 | (ulong)xD << 52 | (ulong)xE << 56 | (ulong)xF << 60;

            return (Perm16)dst;
        }

        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        public static bool symbol(Perm4 src, int index, out Perm4 dst)
        {
            var start = (byte)(index * 2);
            var end = (byte)(start + 1);
            dst = (Perm4)BitMask.between((byte)src, start, end);
            return dst.IsSymbol();
        }

        public static Perm4[] symbols(Perm4 src)
        {            
            var dst = new Perm4[4];
            var fail = new Perm4[0]{};
            for(var i=0; i<dst.Length; i++)
            {
                if(!symbol(src,i, out dst[i]))
                    return fail;
            }

            return dst;
        }

        /// <summary>
        /// Enumerates all permutation map format strings
        /// </summary>
        public static IEnumerable<(Perm4 perm, string format)> maps(N4 n)
            => from perm in EnumValues.Enumerate<Perm4>()
                        where !perm.IsSymbol()
                        let maps = (perm, format:perm.FormatMap())
                        orderby maps.perm descending
                        select maps;

        /// <summary>
        /// Reifies a permutation of length 8 from its canonical scalar specification
        /// </summary>
        /// <param name="spec">The representative</param>
        public static Perm<N8> natural(Perm8 spec)
        {
            uint data = (uint)spec;
            var dst = Perm<N8>.Alloc();
            for(int i=0, offset = 0; i<dst.Length; i++, offset +=3)
                dst[i] = (int)BitMask.between(data, (byte)offset, (byte)(offset + 2));
            return dst;
        }

        /// <summary>
        /// Reifies a permutation of length 16 from its canonical scalar representative 
        /// </summary>
        /// <param name="spec">The representative</param>
        public static Perm<N16> natural(Perm16 spec)
        {
            ulong data = (ulong)spec;
            var dst = Perm<N16>.Alloc();
            for(int i=0, offset = 0; i<dst.Length; i++, offset +=4)
                dst[i] = (int)BitMask.between(data, (byte)offset, (byte)(offset + 3));
            return dst;
        }

        /// <summary>
        /// Maps a permutation on 4 symbols to its canonical scalar specification
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static Perm4 from(Perm<N4> src)
        {
            var dst = 0u;            
            for(int i=0, offset = 0; i< src.Length; i++, offset +=2)
                dst |= (uint)src[i] << offset;                        
            return (Perm4)dst;
        }

        /// <summary>
        /// Maps a permutation on 8 symbols to its canonical scalar specification
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static Perm8 from(Perm<N8> src)
        {
            var dst = 0u;            
            for(int i=0, offset = 0; i< src.Length; i++, offset +=3)
                dst |= (uint)src[i] << offset;                        
            return (Perm8)dst;
        }

        /// <summary>
        /// Maps a permutation on 16 symbols to its canonical scalar representation
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static Perm16 from(Perm<N16> src)
        {
            var dst = 0ul;            
            for(int i=0, offset = 0; i< src.Length; i++, offset +=3)
                dst |= (ulong)src[i] << offset;                        
            return (Perm16)dst;
        }

        public static Perm4 identity(N4 n)
            => Perm4.ABCD;

        public static Perm4 reversed(N4 n)
            => Perm4.DCBA;

        public static Perm16 identity(N16 n)
            => assemble(
                Perm16.X0, Perm16.X1, Perm16.X2, Perm16.X3,
                Perm16.X4, Perm16.X5, Perm16.X6, Perm16.X7,
                Perm16.X8, Perm16.X9, Perm16.XA, Perm16.XB,
                Perm16.XC, Perm16.XD, Perm16.XE, Perm16.XF);
        
        public static Perm16 reversed(N16 n)
            => assemble(
                Perm16.XF,Perm16.XE,Perm16.XD,Perm16.XC,
                Perm16.XB,Perm16.XA,Perm16.X9,Perm16.X8,
                Perm16.X7,Perm16.X6,Perm16.X5,Perm16.X4,
                Perm16.X3,Perm16.X2,Perm16.X1,Perm16.X0);


        [MethodImpl(Inline)]
        static bool includes(Perm16 src, int index)
            => (((int)src & (4 << index)) != 0);

        static PermCycle cycle(Perm16 src)
        {            
            Span<PermTerm> terms = stackalloc PermTerm[16];
            var counter = 0;
            for(var i=0; i<16; i++)   
            {
                if(includes(src,i))
                    terms[counter] = new PermTerm(counter,i);
                counter++;
            }
            return new PermCycle(terms.Slice(0, counter));
        }

    }
}