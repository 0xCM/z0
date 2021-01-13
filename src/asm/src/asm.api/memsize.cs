//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Asm.IceOpKind;

    partial struct asm
    {
        [Op]
        public static IceMemorySize memsize(IceInstruction src, byte index)
        {
            switch(asm.opkind(src,(byte)index))
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
                    return IceMemorySize.Unknown;
            }
        }
    }
}