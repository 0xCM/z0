//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Blit;

    partial struct asm
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static JccInfo<K> jcc<K>(K kind, name64 name, AsmSize size)
            where K : unmanaged
                => new JccInfo<K>(kind, name, size);
    }
}