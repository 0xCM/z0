//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public sealed class FileCatalog
    {
        FS.FolderPath Root;

        public FileCatalog(FS.FolderPath root)
        {
            Root = root;
        }

        public FileCatalog Scoped(FS.FolderPath root)
        {
            Root = root;
            return this;
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