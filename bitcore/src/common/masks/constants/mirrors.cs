//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;

    partial class BitMasks
    {            
        /// <summary>
        /// 0x6 = [0110]
        /// </summary>
        public const byte Mirror4x4x2 = 0x6;

        /// <summary>
        /// 0x66 = [0110_0110]
        /// </summary>
        public const byte Mirror8x4x2 = 0x66;
        
        /// <summary>
        /// 0x666 = [0110_0110_0110]
        /// </summary>
        public const ushort Mirror12x4x2 = 0x666;

        /// <summary>
        /// 0x6666 = [0110_0110_0110_0110]
        /// </summary>
        public const ushort Mirror16x4x2 = 0x6666;

        /// <summary>
        /// 0x66666 = [0110_0110_0110_0110_0110]
        /// </summary>
        public const uint Mirror20x4x2 = 0x66666;

        /// <summary>
        /// 0x666666 = [0110_0110_0110_0110_0110_0110]
        /// </summary>
        public const uint Mirror24x4x2 = 0x666666;

        /// <summary>
        /// 0x66666 = [0110_0110_0110_0110_0110_0110_0110]
        /// </summary>
        public const uint Mirror28x4x2 = 0x6666666;

        /// <summary>
        /// 0x66666666 = [01100110 01100110 01100110 01100110]
        /// </summary>
        public const uint Mirror32x4x2 = 0x66666666;

        /// <summary>
        /// 0x666666666 = [0110 01100110 01100110 01100110 01100110]
        /// </summary>
        public const ulong Mirror36x4x2 = 0x666666666;

        /// <summary>
        /// 0x6666666666 = [01100110 01100110 01100110 01100110 01100110]
        /// </summary>
        public const ulong Mirror40x4x2 = 0x6666666666;

        /// <summary>
        /// 0x66666666666 = [0110_0110_0110_0110_0110_0110_0110_0110_0110_0110_0110]
        /// </summary>
        public const ulong Mirror44x4x2 = 0x66666666666;

        /// <summary>
        /// 0x666666666666 = [0110_0110_0110_0110_0110_0110_0110_0110_0110_0110_0110_0110]
        /// </summary>
        public const ulong Mirror48x4x2 = 0x666666666666;

        /// <summary>
        /// 0x6666666666666 = [0110_0110_0110_0110_0110_0110_0110_0110_0110_0110_0110_0110_0110]
        /// </summary>
        public const ulong Mirror52x4x2 = 0x6666666666666;

        /// <summary>
        /// 0x66666666666666 = [0110_0110_0110_0110_0110_0110_0110_0110_0110_0110_0110_0110_0110_0110]
        /// </summary>
        public const ulong Mirror56x4x2 = 0x66666666666666;

        /// <summary>
        /// 0x666666666666666 = [0110_0110_0110_0110_0110_0110_0110_0110_0110_0110_0110_0110_0110_0110_0110]
        /// </summary>
        public const ulong Mirror60x4x2 = 0x666666666666666;

        /// <summary>
        /// 0x6666666666666666 = [01100110 01100110 01100110 01100110 01100110 01100110 01100110 01100110 01100110 01100110]
        /// </summary>
        public const ulong Mirror64x4x2 = 0x6666666666666666;

        /// <summary>
        /// 0x0FF0 = [0000111111110000]
        /// </summary>
        public const ushort Mirror16x16x8 = 0x0FF0; 

        /// <summary>
        /// 0x0FF00FF0 = [0000111111110000 0000111111110000]
        /// </summary>
        public const uint Mirror32x16x8 = 0x0FF00FF0;

        /// <summary>
        /// 0x0FF00FF00FF00FF0 = [0000111111110000 0000111111110000 0000111111110000 0000111111110000]
        /// </summary>
        public const ulong Mirror64x16x8 = 0x0FF00FF00FF00FF0;

        /// <summary>
        /// 0x00FFFF00
        /// </summary>
        public const uint Mirror32x32x16 = 0x00FFFF00;

        /// <summary>
        /// 0x00FFFF0000FFFF00
        /// </summary>
        public const ulong Mirror64x32x16 = 0x00FFFF0000FFFF00;

        /// <summary>
        /// 0x0000FFFFFFFF0000
        /// </summary>
        public const ulong Mirror64x64x32 = 0x0000FFFFFFFF0000;
    }

}