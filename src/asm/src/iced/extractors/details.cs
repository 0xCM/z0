//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct IceExtractors
    {
        [Op]
        public static IceInstructionInfo details(in IceInstruction src)
        {
            return new IceInstructionInfo
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