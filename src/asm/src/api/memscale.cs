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
        [MethodImpl(Inline), Op]
        public static MemScale memScale(Instruction src, int index)
            => kind(src, (byte)index) == Memory ? src.MemoryIndexScale : MemScale.Empty;
    }
}