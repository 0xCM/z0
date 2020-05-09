//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

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