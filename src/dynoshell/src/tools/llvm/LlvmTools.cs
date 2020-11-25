//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Diagnostics;


    public readonly partial struct Llvm
    {
        public static Llvm service(IWfShell wf)
            => new Llvm(wf);

        readonly IWfShell Wf;

        readonly FS.FolderPath SrcRoot;

        internal Llvm(IWfShell wf)
        {
            Wf= wf;
            SrcRoot = FS.dir("j:/lang/tools/llvm-project");
        }

        public LlvmPaths Paths()
            => new LlvmPaths(SrcRoot);



        public CmdLine llvm_as(FS.FilePath input, FS.FilePath output)
        {
            var dst = Buffers.text();
            var name = LlvmAsCmd.ToolName;
            dst.AppendFormat("{0}", name);
            dst.AppendFormat(" -o {0}", output.Format(PathSeparator.BS));
            dst.AppendFormat(" {0}", input.Format(PathSeparator.BS));
            return dst.Emit();
        }
    }
}