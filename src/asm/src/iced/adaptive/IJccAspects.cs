//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines branch-related instruction aspects
    /// </summary>
    public interface IAsmJccAspects
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
