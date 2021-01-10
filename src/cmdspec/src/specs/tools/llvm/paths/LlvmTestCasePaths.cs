//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;


    public interface ILlvmTestCasePaths : IFileArchive
    {
        FS.FolderPath ModuleDir(string module)
            => Root + FS.folder(module);

        FS.FolderPath ModuleDir(string module, string subject)
            => Root + FS.folder(module) + FS.folder(subject);

        FS.Files ModuleCases(string module)
            => ModuleDir(module).Files(true);

        FS.Files ModuleCases(string module, string subject)
            => ModuleDir(module, subject).Files(true);
    }

    partial struct Llvm
    {
        internal readonly struct TestCasePaths : ILlvmTestCasePaths
        {
            public FS.FolderPath Root {get;}

            public TestCasePaths(FS.FolderPath root)
                => Root = root;
        }
    }
}