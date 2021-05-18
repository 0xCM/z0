//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct CodeBlocks
    {
        [MethodImpl(Inline), Op]
        public static CodeBlockPair pair(MemoryAddress @base, byte[] raw, byte[] parsed)
            => new CodeBlockPair(@base, new CodeBlock(@base, raw), new CodeBlock(@base,parsed));
    }
}