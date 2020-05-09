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
    public interface IJccInstruction
    {
        //
        // Summary:
        //     Checks if it's a jcc short or jcc near instruction
        bool IsJccShortOrNear {get;}

        //
        // Summary:
        //     Checks if it's a jcc short instruction
        bool IsJccShort {get;}

        //
        // Summary:
        //     Checks if it's a jcc near instruction
        bool IsJccNear {get;}

    }
}
