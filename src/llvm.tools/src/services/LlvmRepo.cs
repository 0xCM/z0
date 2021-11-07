//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Collections.Generic;

    using Asm;
    using records;

    using static LlvmNames;
    using static core;

    public class LlvmRepo : AppService<LlvmRepo>
    {
        FS.Files _BuildOutput;

        FS.Files _AllFiles;

        public LlvmRepo()
        {
            _BuildOutput = FS.Files.Empty;
            _AllFiles = FS.Files.Empty;
        }

        public FS.FolderPath Root()
            => Env.LlvmRoot;

        public ReadOnlySpan<FS.FilePath> Files()
        {
            if(_AllFiles.IsEmpty)
            {
                _AllFiles = Root().AllFiles;
            }
            return _AllFiles;
        }

        public ReadOnlySpan<FS.FilePath> Files(FS.FileExt ext)
            => Files().Where(f => f.Is(ext));

        public ReadOnlySpan<FS.FilePath> BuildOutput()
        {
            if(_BuildOutput.IsEmpty)
            {
                _BuildOutput = (BuildRoot()).AllFiles;
            }
            return _BuildOutput;
        }

        public FS.FolderPath BuildRoot()
            => Root() + FS.folder(Repo.build);

        public ReadOnlySpan<FS.FilePath> BuildOutput(FS.FileExt ext)
            =>  BuildOutput().Where(x => x.Is(ext));

        public ReadOnlySpan<FS.FilePath> BuildOutput(FS.FileExt a, FS.FileExt b)
            =>  BuildOutput().Where(x => x.Is(a) || x.Is(b));
    }
}