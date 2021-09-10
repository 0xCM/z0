//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static BitFlow;

    partial struct asm
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NamedRegValue<T> regval<T>(text7 name, T value)
            where T : unmanaged
                => new NamedRegValue<T>(name,value);
    }
}