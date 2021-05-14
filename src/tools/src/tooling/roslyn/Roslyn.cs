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
    using static XmlParts;
    using static CodeSolutions;

    using OmniSharp.Roslyn.CSharp.Services.Documentation;
    using OmniSharp.Models.TypeLookup;

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

        public DocumentationComment GetDocs(XmlText xml)
            => DocumentationConverter.GetStructuredDocumentation(xml.Value, "\n");

        public DocumentationComment GetDocs(ISymbol src)
            => DocumentationConverter.GetStructuredDocumentation(src);

        public SolutionFile LoadSolution(FS.FilePath src)
            => SolutionFile.ParseFile(src.Name);

    }
}