//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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
