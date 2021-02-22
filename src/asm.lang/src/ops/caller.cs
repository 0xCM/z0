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
        public static AsmCaller caller(MemoryAddress @base,  AsmSymbol symbol)
            => new AsmCaller(@base, symbol);

        [MethodImpl(Inline), Op]
        public static AsmCaller caller(MemoryAddress @base,  string name)
            => new AsmCaller(@base, symbol(name));
    }
}