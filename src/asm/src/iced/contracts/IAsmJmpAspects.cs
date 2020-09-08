//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines branch-related instruction aspects
    /// </summary>
    public interface IAsmJmpAspects
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