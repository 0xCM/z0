//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;

public static class Constants
{

    /// <summary>
    /// Defines a bit pattern consisting only of enabled bits
    /// </summary>
    public const byte U8_Ones = byte.MaxValue;


    /// <summary>
    /// Defines a bit pattern consisting only of enabled bits
    /// </summary>
    public const ushort U16_Ones = ushort.MaxValue;


    /// <summary>
    /// Defines a bit pattern consisting only of enabled bits
    /// </summary>
    public const uint U32_Ones = uint.MaxValue;


    /// <summary>
    /// Defines a bit pattern consisting only of enabled bits
    /// </summary>
    public const ulong U64_Ones = ulong.MaxValue;

    /// <summary>
    /// The least significant bit of each 8-bit segment is enabled, the remaining bits are disabled
    /// </summary>
    public const byte U8_LSB = 0x01;

    /// <summary>
    /// The most significant bit of each 8-bit segment is enabled, the remaining bits are disabled
    /// </summary>
    public const byte U8_MSB = 0x80;

    /// <summary>
    /// Defines an alternating bit pattern 1010...10 where the first bit is disabled
    /// </summary>
    public const byte U8_AltEven = 0xAA;

    /// <summary>
    /// Defines an alternating bit pattern 0101...01 where the first bit is enabled
    /// </summary>
    public const byte U8_AltOdd = 0x55;

    /// <summary>
    /// The least significant bit of each 8-bit segment is enabled, the remaining bits are disabled
    /// </summary>
    public const ushort U16_LSB = 0x0101;

    /// <summary>
    /// The most significant bit of each 8-bit segment is enabled, the remaining bits are disabled
    /// </summary>
    public const ushort U16_MSB = 0x8080;

    /// <summary>
    /// Defines an alternating bit pattern 1010...10 where the first bit is disabled
    /// </summary>
    public const ushort U16_AltEven = 0xAAAA;

    /// <summary>
    /// Defines an alternating bit pattern 0101...01 where the first bit is enabled
    /// </summary>
    public const ushort U16_AltOdd = 0x5555;

    /// <summary>
    /// The least significant bit of each 8-bit segment is enabled, the remaining bits are disabled
    /// </summary>
    public const uint U32_LSB = 0x01010101;

    /// <summary>
    /// The most significant bit of each 8-bit segment is enabled, the remaining bits are disabled
    /// </summary>
    public const uint U32_MSB = 0x80808080;

    /// <summary>
    /// Defines an alternating bit pattern 1010...10 where the first bit is disabled
    /// </summary>
    public const uint U32_AltEven = 0xAAAAAAAA;

    /// <summary>
    /// Defines an alternating bit pattern 0101...01 where the first bit is enabled
    /// </summary>
    public const uint U32_AltOdd = 0x55555555;

    /// <summary>
    /// The least significant bit of each 8-bit segment is enabled, the remaining bits are disabled
    /// </summary>
    public const ulong U64_LSB = 0x5555555555555555;

    /// <summary>
    /// The most significant bit of each 8-bit segment is enabled, the remaining bits are disabled
    /// </summary>
    public const ulong U64_MSB = 0x8080808080808080;

    /// <summary>
    /// Defines an alternating bit pattern 1010...10 where the first bit is disabled
    /// </summary>
    public const ulong U64_AltEven = 0xAAAAAAAAAAAAAAAA;

    /// <summary>
    /// Defines an alternating bit pattern 0101...01 where the first bit is enabled
    /// </summary>
    public const ulong U64_AltOdd = 0x5555555555555555;
}


