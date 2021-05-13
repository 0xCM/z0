//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;

    using static Root;
    using static LogRecords;

    [ApiHost]
    public sealed class Roslyn : AppService<Roslyn>, ITool<Roslyn>
    {
        public ToolId Id => Toolsets.roslyn;

        [Op]
        public Compilation<CSharpCompilation> Compilation(MetadataReference src, string name)
            => CSharpCompilation.Create(name, references: new[]{src});

        public Index<CompilerInvocationInfo> CompilerInvocations(FS.FilePath log)
            => BuildLogParser.parse(log);

        public ulong GetKey(ISymbol src)
            => CodeSolutions.SymbolIdService.GetIdULong(src);
    }
}