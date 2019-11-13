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
    using System.Text;

    using static zfunc;    

    /// <summary>
    /// Identifies 4-element permutations
    /// </summary>
    [Flags]
    public enum Perm4 : byte
    {                
        /// <summary>
        /// Identifies the first of four permutation symbols
        /// </summary>
        A = 0b00,

        /// <summary>
        /// Identifies the second of four permutation symbols
        /// </summary>
        B = 0b01,

        /// <summary>
        /// Identifies the third of four permutation symbols
        /// </summary>
        C = 0b10,

        /// <summary>
        /// Identifies the fourth of four permutation symbols
        /// </summary>
        D = 0b11,
        
        /// <summary>
        /// [00 01 10 11]: ABCD -> ABDC
        /// </summary>
        ABCD = A | (B << 2) | (C << 4) | (D << 6),

        /// <summary>
        /// [00 01 11 10]: ABCD -> ABDC
        /// </summary>
        ABDC = A | (B << 2) | (D << 4) | (C << 6),
        
        /// <summary>
        /// [00 10 01 11]: ABCD -> ACBD
        /// </summary>
        ACBD = A | (C << 2) | (B << 4) | (D << 6), 

        /// <summary>
        /// [00 10 11 01]: ABCD -> ACDB
        /// </summary>
        ACDB = A | (C << 2) | (D << 4) | (B << 6), 

        /// <summary>
        /// [00 11 01 10] ABCD -> ADBC
        /// </summary>
        ADBC = A | (D << 2) | (B << 4) | (C << 6), 

        /// <summary>
        /// [00 11 10 01]: ABCD -> ADCB
        /// </summary>
        ADCB = A | (D << 2) | (C << 4) | (B << 6), 

        /// <summary>
        /// [10 00 01 11]: ABCD -> BACD
        /// </summary>
        BACD = B | (A << 2) | (C << 4) | (D << 6), 

        /// <summary>
        /// [10 00 11 10]: ABCD -> BADC
        /// </summary>
        BADC = B | (A << 2) | (D << 4) | (C << 6), 

        /// <summary>
        /// [01 10 00 11]: ABCD -> BCAD
        /// </summary>
        BCAD = B | (C << 2) | (A << 4) | (D << 6), 

        /// <summary>
        /// [01 10 11 00]: ABCD -> BCDA
        /// </summary>
        BCDA = B | (C << 2) | (D << 4) | (A << 6), 

        /// <summary>
        /// [01 11 01 10]: ABCD -> BDAC
        /// </summary>
        BDAC = B | (D << 2) | (A << 4) | (C << 6), 

        /// <summary>
        /// [01 11 10 00]: ABCD -> BDCA
        /// </summary>
        BDCA = B | (D << 2) | (C << 4) | (A << 6), 

        /// <summary>
        /// [10 00 10 11]: ABCD -> CABD
        /// </summary>
        CABD = C | (A << 2) | (B << 4) | (D << 6), 

        /// <summary>
        /// ABCD -> CADB
        /// </summary>
        CADB = C | (A << 2) | (D << 4) | (B << 6), 

        /// <summary>
        /// ABCD -> CBAD
        /// </summary>
        CBAD = C | (B << 2) | (A << 4) | (D << 6), 

        /// <summary>
        /// ABCD -> CBDA
        /// </summary>
        CBDA = C | (B << 2) | (D << 4) | (A << 6), 

        /// <summary>
        /// [10 11 00 01]: ABCD -> CDAB
        /// </summary>
        CDAB = C | (D << 2) | (A << 4) | (B << 6), 

        /// <summary>
        /// [10 11 01 00]: ABCD -> CDBA
        /// </summary>
        CDBA = C | (D << 2) | (B << 4) | (A << 6), 

        /// <summary>
        /// ABCD -> DABC
        /// </summary>
        DABC = D | (A << 2) | (B << 4) | (C << 6), 

        /// <summary>
        /// ABCD -> DACB
        /// </summary>
        DACB = D | (A << 2) | (C << 4) | (B << 6), 

        /// <summary>
        /// [11 01 00 10]: ABCD -> DBAC
        /// </summary>
        DBAC = D | (B << 2) | (A << 4) | (C << 6), 

        /// <summary>
        /// [11 01 10 00]: ABCD -> DBCA
        /// </summary>
        DBCA = D | (B << 2) | (C << 4) | (A << 6), 

        /// <summary>
        /// [11 10 00 01]: ABCD -> DCAB
        /// </summary>
        DCAB = D | (C << 2) | (A << 4) | (B << 6), 

        /// <summary>
        /// [11 10 01 00]: ABCD -> DCBA
        /// </summary>
        DCBA = D | (C << 2) | (B << 4) | (A << 6), 
 
        First = ABCD,

        Last = DCBA
    }

    public static class Perm4Spec
    {
        /// <summary>
        /// Constructs a permutation of length four from four symbols
        /// </summary>
        /// <param name="s0">The symbol in the first position</param>
        /// <param name="s1">The symbol in the second position</param>
        /// <param name="s2">The symbol in the third position</param>
        /// <param name="s3">The symbol in the fourth position</param>
        [MethodImpl(Inline)]
        public static Perm4 assemble(Perm4 s0, Perm4 s1, Perm4 s2, Perm4 s3)
        {               
            var dst = 0u;
            dst |= (uint)s0;
            dst |= (uint)s1 << 2;
            dst |= (uint)s2 << 4;
            dst |= (uint)s3 << 6;
            return (Perm4)dst;
        }

        public static Perm4[] Symbols(this Perm4 src)
        {            
            var dst = new Perm4[4];
            for(var i=0; i<4; i++)
            {
                var sym = src.Symbol(i);
                if(!sym)
                    return new Perm4[0]{};
                sym.OnSome(s => dst[i] = s);
            }
            return dst;
        }

        /// <summary>
        /// Computes the digigs corresponding to each 2-segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static Span<N4, byte> Digits(this Perm4 src)
        {
            var scalar = (byte)src;
            var dst = NatSpan.alloc<N4,byte>();
            dst[0] = BitMask.between(scalar, 0, 1);
            dst[1] = BitMask.between(scalar, 2, 3);
            dst[2] = BitMask.between(scalar, 4, 5);
            dst[3] = BitMask.between(scalar, 6, 7);
            return dst;
        }

        /// <summary>
        /// Maps a permutation on 8 symbols to its canonical scalar specification
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static Perm4 ToNatural(this Perm<N4> src)
        {
            var dst = 0u;            
            for(int i=0, offset = 0; i< src.Length; i++, offset +=2)
                dst |= (uint)src[i] << offset;                        
            return (Perm4)dst;
        }
 
         /// <summary>
        /// Formats the value as a permutation map, i.e., [00 01 10 11]: ABCD -> ABDC
        /// </summary>
        /// <param name="src">The permutation spec</param>
        public static string FormatMap(this Perm4 src)
        {
            static char letter(bit x, bit y)
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

            static string letters(BitString bs)
            {
                Span<char> letters = stackalloc char[4];
                int i=0, j=0;
                letters[i++] = letter(bs[j++], bs[j++]);
                letters[i++] = letter(bs[j++], bs[j++]);
                letters[i++] = letter(bs[j++], bs[j++]);            
                letters[i++] = letter(bs[j++], bs[j++]);            
                return new string(letters);
            }

            var bs = BitString.FromScalar((byte)src);
            var block = bracket(bs.Format(false,false,2, AsciSym.Space));
            var domain = $"{Perm4.A}{Perm4.B}{Perm4.C}{Perm4.D}";
            var codomain = letters(bs);
            var mapping = $"{block}: {domain} -> {codomain}";
            return mapping;
        }     
    }
}