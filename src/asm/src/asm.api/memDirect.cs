//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static IceMemDirect memDirect(in IceInstruction src)
            => new IceMemDirect(src.MemoryBase, src.MemoryIndexScale, dx(src.MemoryDisplacement, (AsmDisplacementSize)src.MemoryDisplSize));
    }
}