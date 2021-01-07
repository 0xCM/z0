//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines flag-related instruction aspects
    /// </summary>
    public interface IAsmFxFlags
    {
        //
        // Summary:
        //     All flags that are read by the CPU when executing the instruction
        IceRflagsBits RflagsRead {get;}
        //
        // Summary:
        //     All flags that are written by the CPU, except those flags that are known to be
        //     undefined, always set or always cleared. See also Iced.Intel.Instruction.RflagsModified
        IceRflagsBits RflagsWritten {get;}
        //
        // Summary:
        //     All flags that are always cleared by the CPU
        IceRflagsBits RflagsCleared {get;}
        //
        // Summary:
        //     All flags that are always set by the CPU
        IceRflagsBits RflagsSet {get;}
        //
        // Summary:
        //     All flags that are undefined after executing the instruction
        IceRflagsBits RflagsUndefined {get;}
        //
        // Summary:
        //     All flags that are modified by the CPU. This is Iced.Intel.Instruction.RflagsWritten
        //     + Iced.Intel.Instruction.RflagsCleared + Iced.Intel.Instruction.RflagsSet + Iced.Intel.Instruction.RflagsUndefined
        IceRflagsBits RflagsModified {get;}
    }
}
