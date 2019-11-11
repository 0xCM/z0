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
    /// Defines literals that identity each 4-element permutation
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
        public static Perm4 Assemble(Perm4 s0, Perm4 s1, Perm4 s2, Perm4 s3)
        {               
            var dst = 0u;
            dst |= (uint)s0;
            dst |= (uint)s1 << 2;
            dst |= (uint)s2 << 4;
            dst |= (uint)s3 << 6;
            return (Perm4)dst;
        }
    }
}