//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public struct Workspace : IWorkspace<Workspace>
    {
        FS.FolderPath _WsRoot;

        public Workspace(FS.FolderPath root)
        {
            _WsRoot = root;
        }

        public Identifier Name
        {
            get => _WsRoot.FolderName.Format();
        }

        public FS.FolderPath Root
        {
            get => _WsRoot;
        }

        public FS.FolderPath WsRoot()
            => _WsRoot;

        public FS.FolderPath WsRoot(FS.FolderPath src)
        {
            _WsRoot = src;
            return WsRoot();
        }

        public FS.FolderPath Subdir(string name)
            => Root + FS.folder(name);

        /// <summary>
        /// Defines a path of the form {Root}/{subdir}/{id}.{ext}
        /// </summary>
        /// <param name="subdir">A subdirectory identifier</param>
        /// <param name="id">A file identifiere</param>
        /// <param name="ext">The target extension</param>
        public FS.FilePath Path(string subdir, string id, FS.FileExt ext)
            => Subdir(subdir) + FS.file(id,ext);

        /// <summary>
        /// Defines a path of the form {Root}/{id}.{ext}
        /// </summary>
        /// <param name="id">A file identifiere</param>
        /// <param name="ext">The target extension</param>
        public FS.FilePath Path(string id, FS.FileExt ext)
            => Root + FS.file(id,ext);

        public string Format()
            => _WsRoot.Format();

        public override string ToString()
            => Format();
    }
}