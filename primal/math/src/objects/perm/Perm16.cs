//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    /// <summary>
    /// Defines canonical literals for representing terms of permutations on 16 symbols
    /// </summary>
    public enum Perm16 : ulong
    {
        X0 = 0,
        
        X1 = 1,
        
        X2 = 2,

        X3 = 3,

        X4 = 4,

        X5 = 5,

        X6 = 6,

        X7 = 7,

        X8 = 8,

        X9 = 9,

        XA = 0xA,

        XB = 0xB,

        XC = 0xC,

        XD = 0xD,

        XE = 0xE,

        XF = 0xF,   

        Identity = 
              X0 << 00 | X1 << 04 | X2 << 08 | X3 << 12 
            | X4 << 16 | X5 << 20 | X6 << 24 | X7 << 28 
            | X8 << 32 | X9 << 36 | XA << 40 | XB << 44 
            | XC << 48 | XD << 52 | XE << 56 | XF << 60

    }

    public static class Perm16Spec
    {
        [MethodImpl(Inline)]
        public static Perm16 Assemble(
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

        public static readonly Perm16 Identity
            = Assemble(
                Perm16.X0, Perm16.X1, Perm16.X2, Perm16.X3,
                Perm16.X4, Perm16.X5, Perm16.X6, Perm16.X7,
                Perm16.X8, Perm16.X9, Perm16.XA, Perm16.XB,
                Perm16.XC, Perm16.XD, Perm16.XE, Perm16.XF);
        
        public static readonly Perm16 Reverse
            = Assemble(
                Perm16.XF,Perm16.XE,Perm16.XD,Perm16.XC,
                Perm16.XB,Perm16.XA,Perm16.X9,Perm16.X8,
                Perm16.X7,Perm16.X6,Perm16.X5,Perm16.X4,
                Perm16.X3,Perm16.X2,Perm16.X1,Perm16.X0);


        [MethodImpl(Inline)]
        public static bool Includes(this Perm16 src, int index)
            => (((int)src & (4 << index)) != 0);

        public static PermCycle Cycle(Perm16 src)
        {            
            Span<PermTerm> terms = stackalloc PermTerm[16];
            var counter = 0;
            for(var i=0; i<16; i++)   
            {
                if(src.Includes(i))
                    terms[counter] = new PermTerm(counter,i);
                counter++;
            }
            return new PermCycle(terms.Slice(0, counter));

        }

        /// <summary>
        /// Maps a permutation on 16 symbols to its canonical scalar representation
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static Perm16 ToSpec(this Perm<N16> src)
        {
            var dst = 0ul;            
            for(int i=0, offset = 0; i< src.Length; i++, offset +=3)
                dst |= (ulong)src[i] << offset;                        
            return (Perm16)dst;
        }

        /// <summary>
        /// Reifies a permutation of length 16 from its canonical scalar representative 
        /// </summary>
        /// <param name="spec">The representative</param>
        public static Perm<N16> ToNatural(this Perm16 spec)
        {
            ulong data = (ulong)spec;
            var dst = Perm<N16>.Alloc();
            for(int i=0, offset = 0; i<dst.Length; i++, offset +=4)
                dst[i] = (int)BitMask.between(data, (byte)offset, (byte)(offset + 3));
            return dst;
        }
    }
}