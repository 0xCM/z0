//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    partial struct asm
    {
        [Op]
        public static InstructionInfo details(in Instruction src)
        {
            return new InstructionInfo
            {
                Encoding = src.Encoding,
                FlowControl = src.FlowControl,
                IsProtectedMode = src.IsProtectedMode,
                IsPrivileged = src.IsPrivileged,
                IsSaveRestoreInstruction = src.IsSaveRestoreInstruction,
                IsStackInstruction = src.IsStackInstruction,
                RflagsCleared = src.RflagsCleared,
                RflagsRead = src.RflagsRead,
                RflagsWritten = src.RflagsWritten,
                RflagsModified = src.RflagsModified,
                RflagsSet = src.RflagsSet,
                RflagsUndefined = src.RflagsUndefined,
                UsedMemory =  src.UsedMemory,
                UsedRegisters = src.UsedRegisters,
                CpuidFeatures = src.CpuidFeatures,
                Access = src.Access(),
            };
        }
    }
}