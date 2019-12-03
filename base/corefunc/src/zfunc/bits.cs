//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// A bit with state 1
    /// </summary>
    public static bit on
    {
        [MethodImpl(Inline)]
        get => bit.On;
    }

    /// <summary>
    /// A bit with state 0
    /// </summary>
    public static bit off
    {
        [MethodImpl(Inline)]
        get => bit.Off;
    }

    [MethodImpl(Inline)]
    public static ushort bswap(ushort src)
    {
        var dst = src >> 8;
        dst |= ((0xFF & src) << 8);
        return (ushort)dst;

    }

    [MethodImpl(Inline)]
    public static uint bswap(uint src)
    {
        var dst = 0u;
        dst |= (uint)(byte)(src >> 3*8) << 0;
        dst |= (uint)(byte)(src >> 2*8) << 8;
        dst |= (uint)(byte)(src >> 1*8) << 16;
        dst |= (uint)(byte)(src >> 0*8) << 24;
        return dst;
    }

    [MethodImpl(Inline)]
    public static ulong bswap(ulong src)
    {
        var dst = 0ul;
        dst |= (ulong)(byte)(src >> 7*8) << 0;
        dst |= (ulong)(byte)(src >> 6*8) << 8;
        dst |= (ulong)(byte)(src >> 5*8) << 16;
        dst |= (ulong)(byte)(src >> 4*8) << 24;
        dst |= (ulong)(byte)(src >> 3*8) << 32;
        dst |= (ulong)(byte)(src >> 2*8) << 40;
        dst |= (ulong)(byte)(src >> 1*8) << 48;
        dst |= (ulong)(byte)(src >> 0*8) << 56;
        return dst;
    }

}