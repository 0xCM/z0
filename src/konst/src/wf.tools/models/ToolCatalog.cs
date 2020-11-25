//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ToolCatalog
    {
        readonly FS.FolderPath Root;

        readonly FS.FileExt HelpExt;

        [MethodImpl(Inline)]
        public ToolCatalog(FS.FolderPath root)
        {
            Root = root;
            HelpExt = FS.ext("help");
        }

        public FS.FilePath Help(ToolId tool)
        {
            var match = FS.file(tool.Format());
            var path = HelpDir.Files(HelpExt).Where(f => f.FileName.WithoutExtension.Equals(match)).FirstOrDefault();
            return path;
        }

        public Files Help()
            => HelpDir.Files(FS.ext("help"));

        FS.FolderPath HelpDir
            => Root + FS.folder("help");
    }
}