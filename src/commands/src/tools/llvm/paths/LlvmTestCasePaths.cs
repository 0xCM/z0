//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Llvm
    {
        public readonly struct TestCasePaths
        {
            public FS.FolderPath Root {get;}

            public TestCasePaths(FS.FolderPath root)
                => Root = root;

            [MethodImpl(Inline)]
            public TestCasePaths Update(FS.FolderPath root)
                => new TestCasePaths(root);

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
}