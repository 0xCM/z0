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
    /// Defines call-related instruction aspects
    /// </summary>
    public interface IAsmInxsCall
    {
        //
        // Summary:
        //     Checks if it's a call near instruction
        bool IsCallNear {get;}
        //
        // Summary:
        //     Checks if it's a call far instruction
        bool IsCallFar {get;}

        //
        // Summary:
        //     Checks if it's a call near reg/[mem] instruction
        bool IsCallNearIndirect {get;}

        //
        // Summary:
        //     Checks if it's a call far [mem] instruction
        bool IsCallFarIndirect {get; set;}
    }
}