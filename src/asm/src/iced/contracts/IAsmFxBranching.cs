//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Aggregates call/jmp/branching instruction aspects
    /// </summary>
    public interface IAsmFxBranching  : IAsmJccAspects, IAsmJmpAspects, IAsmFxCall, IAsmFxBranch
    {

    }
}