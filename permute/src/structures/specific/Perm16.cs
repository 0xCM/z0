//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;    

    /// <summary>
    /// Defines a 16-symbol permutation 
    /// </summary>
    public readonly ref struct Perm16
    {
        internal readonly Vector128<byte> data;

        [MethodImpl(Inline)]
        public static Perm16 from(NatPerm<N16,byte> spec)
            => new Perm16(vgeneric.vload(w, spec.Terms));

        [MethodImpl(Inline)]
        public static Perm16 from(Vector128<byte> data)
            => new Perm16(dvec.vand(data, vgeneric.vbroadcast(w, BitMasks.Msb8x8x3)));

        /// <summary>
        /// Creates the identity permutation
        /// </summary>
        public static Perm16 identity()
            => new Perm16(Data.vincrements<byte>(w));

        /// <summary>
        /// Creates the reversal of the identity permutation
        /// </summary>
        public static Perm16 reverse()
            => new Perm16(Data.decrements<byte>(w));

        Perm16(Vector128<byte> data)
            => this.data = data;

        static N128 w => Nats.n128;        
    }


    /// <summary>
    /// Defines canonical literals for representing terms of permutations on 16 symbols
    /// </summary>
    public enum Perm16Sym : ulong
    {
        X0 = 0b0000,
        
        X1 = 0b0001,
        
        X2 = 0b0010,

        X3 = 0b0011,

        X4 = 0b0100,

        X5 = 0b0101,

        X6 = 0b0110,

        X7 = 0b0111,

        X8 = 0b1000,

        X9 = 0b1001,

        XA = 0b1010,

        XB = 0b1011,

        XC = 0b1100,

        XD = 0b1101,

        XE = 0b1110,

        XF = 0b1111,   
    }


    /// <summary>
    /// Defines canonical literals for representing terms of permutations on 16 symbols
    /// </summary>
    public enum Perm16L : ulong
    {
        X0 = Perm16Sym.X0,
        
        X1 = Perm16Sym.X1,
        
        X2 = Perm16Sym.X2,

        X3 = Perm16Sym.X3,

        X4 = Perm16Sym.X4,

        X5 = Perm16Sym.X5,

        X6 = Perm16Sym.X6,

        X7 = Perm16Sym.X7,

        X8 = Perm16Sym.X8,

        X9 = Perm16Sym.X9,

        XA = Perm16Sym.XA,

        XB = Perm16Sym.XB,

        XC = Perm16Sym.XC,

        XD = Perm16Sym.XD,

        XE = Perm16Sym.XE,

        XF = Perm16Sym.XF,

        Identity = 
              X0 << 00 | X1 << 04 | X2 << 08 | X3 << 12 
            | X4 << 16 | X5 << 20 | X6 << 24 | X7 << 28 
            | X8 << 32 | X9 << 36 | XA << 40 | XB << 44 
            | XC << 48 | XD << 52 | XE << 56 | XF << 60,    
    }
}