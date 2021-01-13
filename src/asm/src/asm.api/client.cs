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
        public static AsmCallClient client(MemoryAddress @base)
            => new AsmCallClient(@base);

        [MethodImpl(Inline), Op]
        public static AsmCallClient client(string id, MemoryAddress @base)
            => new AsmCallClient(id, @base);
    }
}