//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines call-related instruction aspects
    /// </summary>
    public interface IAsmFxCall
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