//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static AsmRegValue<T> regval<T>(AsmRegName name, T value)
            where T : unmanaged
                => new AsmRegValue<T>(name,value);
    }
}