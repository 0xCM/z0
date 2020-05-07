//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines IP-related instruction aspects
    /// </summary>
    public interface IAsmInxsIp
    {
        //
        // Summary:
        //     64-bit IP of the instruction
        ulong IP {get;}

        //
        // Summary:
        //     16-bit IP of the instruction
        ushort IP16 {get;}

        //
        // Summary:
        //     32-bit IP of the instruction
        uint IP32 {get;}

        //
        // Summary:
        //     64-bit IP of the next instruction
        ulong NextIP {get;}

        //
        // Summary:
        //     16-bit IP of the next instruction
        ushort NextIP16 {get;}

        //
        // Summary:
        //     32-bit IP of the next instruction
        uint NextIP32 {get;}

    }
}
