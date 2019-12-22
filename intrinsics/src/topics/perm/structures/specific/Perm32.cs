//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    
    /// <summary>
    /// Defines a 32-symbol permutation
    /// </summary>
    public readonly ref struct Perm32
    {            
        internal readonly Vector256<byte> data;
        
        [MethodImpl(Inline)]
        public static Perm32 from(NatPerm<N32,byte> spec)
            => new Perm32(ginx.vload(w, spec.Terms));

        [MethodImpl(Inline)]
        public static Perm32 from(Vector256<byte> data)
            => new Perm32(dinx.vand(data, CpuVector.broadcast(w, BitMasks.Msb8x8x3)));

        /// <summary>
        /// Creates the identity permutation
        /// </summary>
        [MethodImpl(Inline)]
        public static Perm32 identity()
            => new Perm32(CpuVector.increments<byte>(w));

        /// <summary>
        /// Creates the reversal of the identity permutation
        /// </summary>
        [MethodImpl(Inline)]
        public static Perm32 reverse()
            => new Perm32(CpuVector.decrements<byte>(w));

        Perm32(Vector256<byte> data)
            => this.data = data;

        static N256 w => n256;
    }

    /// <summary>
    /// Defines canonical literals for representing terms of permutations on 16 symbols
    /// </summary>
    public enum Perm32Sym : byte
    {
        X0 = 0b00000,
        
        X1 = 0b00001,
        
        X2 = 0b00010,

        X3 = 0b00011,

        X4 = 0b00100,

        X5 = 0b00101,

        X6 = 0b00110,

        X7 = 0b00111,

        X8 = 0b01000,

        X9 = 0b01001,

        XA = 0b01010,

        XB = 0b01011,

        XC = 0b01100,

        XD = 0b01101,

        XE = 0b01110,

        XF = 0b01111,   

        XG = 0b10000,
        
        XH = 0b10001,
        
        XI = 0b10010,

        XJ = 0b10011,

        XK = 0b10100,

        XL = 0b10101,

        XM = 0b10110,

        XN = 0b10111,

        XO = 0b11000,

        XP = 0b11001,

        XQ = 0b11010,

        XR = 0b11011,

        XS = 0b11100,

        XT = 0b11101,

        XU = 0b11110,

        XV = 0b11111,   

    }

}