//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    [ApiHost]
    public readonly partial struct Llvm
    {
        [MethodImpl(Inline), Op]
        public static Llvm tool(IEnvPaths paths)
            => new Llvm(paths);

        readonly IEnvPaths Paths;

        readonly FS.FolderPath SrcRoot;

        Llvm(IEnvPaths paths)
        {
            Paths = paths;
            SrcRoot = FS.dir("j:/source/llvm-project");
        }

        public CmdLine llvm_as(FS.FilePath input, FS.FilePath output)
        {
            var dst = text.buffer();
            var name = ToolNames.@as;
            dst.AppendFormat("{0}", name);
            dst.AppendFormat(" -o {0}", output.Format(PathSeparator.BS));
            dst.AppendFormat(" {0}", input.Format(PathSeparator.BS));
            return dst.Emit();
        }
    }
}