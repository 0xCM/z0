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
    /// Aggregates call/jmp/branching instruction aspects
    /// </summary>
    public interface IInstructionFlow  : IJccInstruction, IJmpInstruction, ICalInstruction, IInstructionBranch
    {
        
    }
}