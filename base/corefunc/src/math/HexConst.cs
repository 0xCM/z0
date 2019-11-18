//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    

    /// <summary>
    /// Defines proof attempts for type naturals
    /// </summary>
    public static class HexConst
    {
        public const byte x1 = 0x1;

        public const byte x11 = 0x11;

        public const byte x2 = 0x2;

        public const byte x22 = 0x22;

        public const byte x5 = 0x5;

        public const byte x55 = 0x55;

        public const byte A = 0xA;

        public const byte AA = 0xAA;

        public const byte B = 0xB;

        public const byte BB = 0xBB;

        public const byte C = 0xC;

        public const byte CC = 0xCC;

        public const byte D = 0xD;

        public const byte DD = 0xDD;

        public const byte E = 0xE;

        public const byte EE = 0xEE;

        public const byte F = 0xF;

        public const byte FF = 0xFF;

        /// <summary>
        /// Defines an odd sequence of 16 alternating bits, 0b01...01
        /// </summary>
        public const ushort x5555 = 0x5555;
        
        /// <summary>
        /// Defines an even sequence of 16 alternating bits, 0b10...10
        /// </summary>
        public const ushort xAAAA = 0xAAAA;    

        /// <summary>
        /// Defines an odd sequence of 32 alternating bits, 0b01...01
        /// </summary>
        public const uint x55555555 = 0x55555555;
        
        /// <summary>
        /// Defines an even sequence of 32 alternating bits, 0b10...10
        /// </summary>
        public const uint xAAAAAAAA = 0xAAAAAAAA;    

        /// <summary>
        /// Defines an odd sequence of 64 alternating bits, 0b01...01
        /// </summary>
        public const ulong x5555555555555555 = 0x5555555555555555;
        
        /// <summary>
        /// Defines an even sequence of 64 alternating bits, 0b10...10
        /// </summary>
        public const ulong xAAAAAAAAAAAAAAAA = 0xAAAAAAAAAAAAAAAA;    

        public const ulong x0000FFFFFFFF0000 = 0x0000FFFFFFFF0000;
        
        public const uint x00FFFF00 = 0x00FFFF00;

        public const ulong x00FFFF0000FFFF00 = 0x00FFFF0000FFFF00;

        public const ushort x0FF0 = 0x0FF0;    

        public const uint x0FF00FF0 = 0x0FF00FF0;    

        public const ulong x0FF00FF00FF00FF0 = 0x0FF00FF00FF00FF0;

        /// <summary>
        /// Defines a 4-bit interior segment of enabled bits, 0b00_1111_00
        /// </summary>
        public const byte x3C = 0x3C;

        /// <summary>
        /// Defines a sequence of alternating 4-bit segments, 0b00_1111_0000_1111_..._0000_1111_00
        /// </summary>
        public const ushort x3C3C = 0x3C3C;

        /// <summary>
        /// Defines a sequence of alternating 4-bit segments, 0b00_1111_0000_1111_..._0000_1111_00
        /// </summary>
        public const uint x3C3C3C3C = 0x3C3C3C3C;

        /// <summary>
        /// Defines a sequence of alternating 4-bit segments, 0b00_1111_0000_1111_..._0000_1111_00
        /// </summary>
        public const ulong x3C3C3C3C3C3C3C3C = 0x3C3C3C3C3C3C3C3C;

        /// <summary>
        /// Defines a sequence of alternating 2-bit segments, 0b0_11_00_11_0
        /// </summary>
        public const byte x66 = 0x66;

        /// <summary>
        /// Defines a sequence of alternating 2-bit segments, 0b0_11_00_11_00_..._11_00_11_0 
        /// </summary>
        public const ushort x6666 = 0x6666;

        /// <summary>
        /// Defines a sequence of alternating 2-bit segments, 0b0_11_00_11_00_..._11_00_11_0 
        /// </summary>
        public const uint x66666666 = 0x66666666;
        
        /// <summary>
        /// Defines a sequence of alternating 2-bit segments, 0b0_11_00_11_00_..._11_00_11_0 
        /// </summary>
        public const ulong x6666666666666666 = 0x6666666666666666;
    }
}
