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
    /// Defines branch-related instruction aspects
    /// </summary>
    public interface IJmpInstruction
    {
        //
        // Summary:
        //     Checks if it's a jmp short instruction
        bool IsJmpShort {get;}

        //
        // Summary:
        //     Checks if it's a jmp near instruction
        bool IsJmpNear {get;}

        //
        // Summary:
        //     Checks if it's a jmp short or a jmp near instruction
        bool IsJmpShortOrNear {get;}
        
        //
        // Summary:
        //     Checks if it's a jmp far instruction
        bool IsJmpFar {get;}

        //
        // Summary:
        //     Checks if it's a jmp near reg/[mem] instruction
        bool IsJmpNearIndirect {get;}
        //
        // Summary:
        //     Checks if it's a jmp far [mem] instruction
        bool IsJmpFarIndirect {get;}

    }
}