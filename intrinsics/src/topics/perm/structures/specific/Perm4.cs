//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public enum Perm4Sym : byte
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

    }

    /// <summary>
    /// Identifies 4-element permutations
    /// </summary>
    public enum Perm4L : byte
    {                
        /// <summary>
        /// Identifies the first of four permutation symbols
        /// </summary>
        A = Perm4Sym.A,

        /// <summary>
        /// Identifies the second of four permutation symbols
        /// </summary>
        B = Perm4Sym.B,

        /// <summary>
        /// Identifies the third of four permutation symbols
        /// </summary>
        C = Perm4Sym.C,

        /// <summary>
        /// Identifies the fourth of four permutation symbols
        /// </summary>
        D = Perm4Sym.D,
        
        /// <summary>
        /// ABCD -> ABCD
        /// </summary>
        ABCD = A | B << 2 | C << 4 | D << 6,

        /// <summary>
        /// ABCD -> ABDC
        /// </summary>
        ABDC = A | (B << 2) | (D << 4) | (C << 6),
        
        /// <summary>
        /// ABCD -> ACBD
        /// </summary>
        ACBD = A | (C << 2) | (B << 4) | (D << 6), 

        /// <summary>
        /// ABCD -> ACDB
        /// </summary>
        ACDB = A | (C << 2) | (D << 4) | (B << 6), 

        /// <summary>
        /// ABCD -> ADBC
        /// </summary>
        ADBC = A | (D << 2) | (B << 4) | (C << 6), 

        /// <summary>
        /// ABCD -> ADCB
        /// </summary>
        ADCB = A | (D << 2) | (C << 4) | (B << 6), 

        /// <summary>
        /// ABCD -> BACD
        /// </summary>
        BACD = B | (A << 2) | (C << 4) | (D << 6), 

        /// <summary>
        /// ABCD -> BADC
        /// </summary>
        BADC = B | (A << 2) | (D << 4) | (C << 6), 

        /// <summary>
        /// ABCD -> BCAD
        /// </summary>
        BCAD = B | C << 2 | A << 4 | D << 6, 

        /// <summary>
        /// ABCD -> BCDA
        /// </summary>
        BCDA = B | (C << 2) | (D << 4) | (A << 6), 

        /// <summary>
        /// ABCD -> BDAC
        /// </summary>
        BDAC = B | (D << 2) | (A << 4) | (C << 6), 

        /// <summary>
        /// ABCD -> BDCA
        /// </summary>
        BDCA = B | (D << 2) | (C << 4) | (A << 6), 

        /// <summary>
        /// ABCD -> CABD
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
        /// ABCD -> CDAB
        /// </summary>
        CDAB = C | (D << 2) | (A << 4) | (B << 6), 

        /// <summary>
        /// ABCD -> CDBA
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
        /// ABCD -> DBAC
        /// </summary>
        DBAC = D | (B << 2) | (A << 4) | (C << 6), 

        /// <summary>
        /// ABCD -> DBCA
        /// </summary>
        DBCA = D | (B << 2) | (C << 4) | (A << 6), 

        /// <summary>
        /// ABCD -> DCAB
        /// </summary>
        DCAB = D | (C << 2) | (A << 4) | (B << 6), 

        /// <summary>
        /// ABCD -> DCBA
        /// </summary>
        DCBA = D | C << 2 | B << 4 | A << 6, 
    }
}