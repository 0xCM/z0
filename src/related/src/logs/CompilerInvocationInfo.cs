//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct LogRecords
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct CompilerInvocationInfo : IRecord<CompilerInvocationInfo>
        {
            public const string TableId = "build.compiler-invocations";

            public FS.FilePath ProjectFilePath;

            public FS.FilePath OutputAssemblyPath;

            public CmdLine CommandLine;

            public FS.FilePath CompilerPath;

            public FS.FilePath IntermediateAssemblyPath;

            public Name AssemblyName;

            public DelimitedIndex<FS.FilePath> ReferencedBinaries;

            public DelimitedIndex<FS.FilePath> TypeScripFiles;

            public string Language;

            public string Summary;
        }
    }
}