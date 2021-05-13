//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;

    using static Root;

    [ApiHost]
    public sealed partial class Roslyn : AppService<Roslyn>, ITool<Roslyn>
    {
        public ToolId Id => Toolsets.roslyn;

        [Op]
        public Compilation Compilation(MetadataReference src, string name)
            => CSharpCompilation.Create(name, references: new[]{src});
    }
}