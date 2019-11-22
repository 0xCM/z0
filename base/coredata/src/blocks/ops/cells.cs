//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    partial class DataBlocks
    {
        /// <summary>
        /// Creates a 64-bit blocked span
        /// </summary>
        [MethodImpl(Inline)]
        public static Block64<byte> cells(N64 n, 
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
                => load(n,x0,x1,x2,x3,x4,x5,x6,x7);

        /// <summary>
        /// Creates a 128-bit blocked span
        /// </summary>
        [MethodImpl(Inline)]
        public static Block128<byte> cells(N128 n, 
            byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, 
            byte x8, byte x9, byte xA, byte xB, byte xC, byte xD, byte xE, byte xF)
                => load(n,x0,x1,x2,x3,x4,x5,x6,x7,x8,x9,xA,xB,xC,xD,xE,xF);

    }

}