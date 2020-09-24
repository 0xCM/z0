//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;

    using static z;

    public struct ToolProxyGen
    {
        public ToolProxyGen(FS.FilePath dst)
        {
            TargetPath = dst;
        }

        public FS.FilePath TargetPath;

        public string Pattern => $@"
using System;
using System.Diagnostics;
using System.Linq;

class Program
{{
    public static int Main(string[] args)
    {{
        var arguments = string.Join("" "", args.Select(a => $""\""{{a}}\""""));
        var psi = new ProcessStartInfo
        {{
	        FileName = {TargetPath},
	        UseShellExecute = false,
	        Arguments = arguments,
			CreateNoWindow = false,
        }};
        var process = Process.Start(psi);
		Console.CancelKeyPress += (s, e) => {{ e.Cancel = true; }};
        process.WaitForExit();
        return process.ExitCode;
    }}
}};
";
        public MetadataReference[] References
            => CodeGen.pe(typeof(object),typeof(Enumerable),typeof(ProcessStartInfo));

        public static CSharpCompilation compilation(ToolProxy config)
        {
            z.insist(config.Source.Exists, $"The file {config.Source}, it must exist");

            var dst = FS.create(config.OutDir) + FS.file(config.Name, ArchiveExt.Exe);
            var gen = new ToolProxyGen(dst);

            return CodeGen.compilation(config.Name)
                          .AddReferences(gen.References)
                          .AddSyntaxTrees(CSharpSyntaxTree.ParseText(gen.Pattern));

        }
    }
}