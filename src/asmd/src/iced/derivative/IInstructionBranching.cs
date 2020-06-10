//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    /// <summary>
    /// Aggregates call/jmp/branching instruction aspects
    /// </summary>
    public interface IInstructionBranching  : IJccAspects, IJmpAspects, ICalInstruction, IInstructionBranch
    {
        
    }
}