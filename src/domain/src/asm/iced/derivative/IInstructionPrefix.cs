//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IInstructionPrefix
    {
        //
        // Summary:
        //     Checks if the instruction has the XACQUIRE prefix (F2)
        bool HasXacquirePrefix {get;}

        //
        // Summary:
        //     Checks if the instruction has the XACQUIRE prefix (F3)
        bool HasXreleasePrefix {get;}

        //
        // Summary:
        //     Checks if the instruction has the REPE or REP prefix (F3)
        bool HasRepPrefix {get;}

        //
        // Summary:
        //     Checks if the instruction has the REPE or REP prefix (F3)
        bool HasRepePrefix {get;}
        
        //
        // Summary:
        //     Checks if the instruction has the REPNE prefix (F2)
        bool HasRepnePrefix {get;}
        //
        // Summary:
        //     Checks if the instruction has the LOCK prefix (F0)
        bool HasLockPrefix {get;}
    }
}