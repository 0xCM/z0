//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public sealed class FileCatalog : AppService<FileCatalog>
    {
        FS.FolderPath Root;

        protected override void OnInit()
        {
            Root = Db.Root;
        }
        public FileCatalog Scoped(FS.FolderPath root)
        {
            var dst = create(Wf);
            dst.Root = root;
            return dst;
        }

        public ReadOnlySpan<FS.FilePath> Files
        {
            get => Root.Files(true).View;
        }

        public void Enumerate(Action<FS.FilePath> receiver, bool recurse = true)
        {
            foreach(var file in Root.EnumerateFiles(recurse))
                receiver(file);
        }
    }
}