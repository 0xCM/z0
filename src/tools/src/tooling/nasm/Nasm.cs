//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;



    [ApiHost]
    public readonly partial struct Nasm : ITool<Nasm>
    {
        [MethodImpl(Inline)]
        public static Nasm tool(IEnvPaths paths)
            => new Nasm(paths);

        public FS.FolderPath InDir
            => Paths.ToolInDir(Id);

        public FS.FolderPath OutDir
            => Paths.ToolOutDir(Id);

        public FS.Files InFiles()
            => Paths.ToolInDir(Id).AllFiles;

        public FS.Files ListingFiles()
            => InDir.Files(FS.ext("list") + FS.Asm);

        public FS.Files OutFiles()
            => Paths.ToolInDir(Id).AllFiles;

        public NasmListing Listing(FS.FilePath src)
        {
            var dst = root.list<TextLine>();
            using var reader = src.Reader();
            var i = 1u;
            while(!reader.EndOfStream)
                new TextLine(i++, reader.ReadLine());
            return new NasmListing(src, dst.ToArray());
        }

        readonly IEnvPaths Paths;

        [MethodImpl(Inline)]
        Nasm(IEnvPaths paths)
            => Paths = paths;

        public ToolId Id => Toolsets.nasm;
    }
}