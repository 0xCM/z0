//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;


    using static Seed;    
    using static Control;
    using static Symbolic;

    using HSU = HexSymUp;
    using HSL = HexSymLo;

    partial class SymbolicData
    {
        public static IEnumerable<MemRef> Refs
            => seq(memref(UpperHexSymbolData),
                memref(LowerHexSymbolData), 
                memref(UpperHexCodes), 
                memref(LowerHexCodes));

        /// <summary>
        /// Defines a 16-element sequence with terms that correspond to the uppercase hex symbolic literals
        /// </summary>
        public static ReadOnlySpan<HSU> UpperHexSymbols
        {
            [MethodImpl(Inline)]
            get => cast<HSU>(UpperHexSymbolData);
        }

        /// <summary>
        /// Defines a 16-element sequence with terms that correspond to the lowercase hex symbolic literals
        /// </summary>
        public static ReadOnlySpan<HSL> LowerHexSymbols 
        {
            [MethodImpl(Inline)]
            get => cast<HSL>(LowerHexSymbolData);
        }

        public static ReadOnlySpan<byte> UpperHexSymbolData
            => new byte[]{
                (byte)HSU.x0, 0, (byte)HSU.x1, 0, (byte)HSU.x2, 0, (byte)HSU.x3, 0,
                (byte)HSU.x4, 0, (byte)HSU.x5, 0, (byte)HSU.x6, 0, (byte)HSU.x7, 0,
                (byte)HSU.x8, 0, (byte)HSU.x9, 0, 
                (byte)HSU.A,  0,  (byte)HSU.B, 0, 
                (byte)HSU.C,  0, (byte)HSU.D,  0, (byte)HSU.E,  0,  (byte)HSU.F, 0,
                };

        public static ReadOnlySpan<byte> LowerHexSymbolData
            => new byte[]{
                (byte)HSL.x0, 0, (byte)HSL.x1, 0, (byte)HSL.x2, 0, (byte)HSL.x3, 0,
                (byte)HSL.x4, 0, (byte)HSL.x5, 0, (byte)HSL.x6, 0, (byte)HSL.x7, 0,
                (byte)HSL.x8, 0, (byte)HSL.x9, 0,                 
                (byte)HSL.a,  0,  (byte)HSL.b, 0, 
                (byte)HSL.c,  0, (byte)HSL.d,  0, (byte)HSL.e,  0,  (byte)HSL.f, 0,
                };
    }
}