//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct Llvm
    {
        [MethodImpl(Inline), Op]
        public static Llvm create(FS.FolderPath root)
            => new Llvm(root);

        readonly FS.FolderPath Root;

        Llvm(FS.FolderPath root)
        {
            Root = root;
        }

        public CmdLine llvm_as(FS.FilePath input, FS.FilePath output)
        {
            var dst = text.buffer();
            var name = Toolspace.llvm_as;
            dst.AppendFormat("{0}", name);
            dst.AppendFormat(" -o {0}", output.Format(PathSeparator.BS));
            dst.AppendFormat(" {0}", input.Format(PathSeparator.BS));
            return dst.Emit();
        }
    }
}