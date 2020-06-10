//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static AspectLabels;

    /// <summary>
    /// Defines call-related instruction aspects
    /// </summary>
    public interface ICalInstruction
    {
        //
        // Summary:
        //     Checks if it's a call near instruction
        [Label(near)]
        bool IsCallNear {get;}
        //
        // Summary:
        //     Checks if it's a call far instruction
        [Label(far)]
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