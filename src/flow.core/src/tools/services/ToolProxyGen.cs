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

    using Z0.Tools;

    public struct ToolProxyGen
    {    
        public ToolProxyGen(FilePath dst)
        {
            TargetPath = dst;
        }
        
        public FilePath TargetPath;

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
            z.insist(config.Source);
            var dst = config.OutDir.Create() + FileName.Define(config.Name, FileExtensions.Exe);
            var gen = new ToolProxyGen(dst);

            return CodeGen.compilation(config.Name)
                          .AddReferences(gen.References)
                          .AddSyntaxTrees(CSharpSyntaxTree.ParseText(gen.Pattern));

        }
    }
}