//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    public class YamlBench : ToolService<YamlBench>
    {
        Symbols<YamlTokenKind> Kinds;

        public YamlBench()
        {
            Kinds = Symbols.index<YamlTokenKind>();
        }

        public override ToolId Id
            => LlvmToolNames.yaml_bench;

        [MethodImpl(Inline), Op]
        public static bool eq(ReadOnlySpan<char> a, ReadOnlySpan<char> b)
        {
            var count = a.Length;
            var result = count == b.Length;
            for(var i=0; i<count && result; i++)
                result = skip(a,i) == skip(b,i);
            return result;
        }
    }
}