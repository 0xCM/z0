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
    using static Asm.OpKind;

    partial struct asm
    {
        [Op]
        public static MemorySize memSize(Instruction src, int index)
        {
            switch(asm.kind(src,(byte)index))
            {
                case Memory:
                case Memory64:
                case MemorySegSI:
                case MemorySegESI:
                case MemorySegRSI:
                case MemoryESDI:
                case MemoryESEDI:
                case MemoryESRDI:
                    return src.MemorySize;
                default:
                    return MemorySize.Unknown;
            }
        }
    }
}