//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LlvmTestCasePaths
    {
        public FS.FolderPath Root {get;}

        public LlvmTestCasePaths(FS.FolderPath root)
            => Root = root;

        [MethodImpl(Inline)]
        public LlvmTestCasePaths Update(FS.FolderPath root)
            => new LlvmTestCasePaths(root);

        public FS.FolderPath ModuleDir(string module)
            => Root + FS.folder(module);

        public FS.FolderPath ModuleDir(string module, string subject)
            => Root + FS.folder(module) + FS.folder(subject);

        public FS.Files ModuleCases(string module)
            => ModuleDir(module).Files(true);

        public FS.Files ModuleCases(string module, string subject)
            => ModuleDir(module, subject).Files(true);
    }
}