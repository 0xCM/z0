//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    using static Konst;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static MemInfo memInfo(IceRegister sReg, IceRegister prefix, MemDirect mem, MemoryAddress address, MemorySize size)
            => new MemInfo(sReg, prefix, mem, address, size);

        [Op]
        public static MemInfo memInfo(Instruction src, int index)
        {
            var k = kind(src, index);

            if(isMem(k))
            {
                var direct = isMemDirect(k);
                var segBase = isSegBase(k);
                var mem64 = isMem64(k);
                var info = new MemInfo();
                var sz = src.MemorySize;
                var memdirect = direct ? memDirect(src) : MemDirect.Empty;
                var prefix = (direct || segBase) ? src.SegmentPrefix : Z0.Asm.IceRegister.None;
                var sReg = (direct || segBase) ? src.MemorySegment : Z0.Asm.IceRegister.None;
                var address = mem64 ? src.MemoryAddress64 : 0;
                return new MemInfo(sReg, prefix, memdirect, address, sz);
            }

            return default;
        }

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
                UsedMemory =  src.UsedMemory(),
                UsedRegisters = src.UsedRegisters(),
                CpuidFeatures = src.CpuidFeatures,
                Access = src.Access(),
            };
        }
    }
}