//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct HostEmissionPaths
    {
        [MethodImpl(Inline)]
        public static HostEmissionPaths Define(ApiHostUri host, RootEmissionPaths root)
            => new HostEmissionPaths(host, root);


        [MethodImpl(Inline)]
        HostEmissionPaths(ApiHostUri host, RootEmissionPaths root)
        {
            this.Host = host;
            this.Root = root;
        }

        public readonly RootEmissionPaths Root;
                
        public readonly ApiHostUri Host;

        FileName BaseFileName => FileName.Define(text.concat(Host.Owner.Format(), text.dot(),  Host.Name));

        public FolderPath ExtractDir => Root.ExtractDir;

        public FileExtension ExtractExt => FileExtension.Define($"x.{FileExtensions.Csv}");

        public FileName ExtractFileName => BaseFileName + ExtractExt;

        public FilePath ExtractPath => ExtractDir + ExtractFileName;

        public FolderPath ParsedDir  => Root.ParsedDir;
        
        public FileExtension ParsedExt => FileExtension.Define($"p.{FileExtensions.Csv}");

        public FileName ParsedFileName => BaseFileName + ParsedExt;

        public FilePath ParsedPath => ParsedDir + ParsedFileName;

        public FolderPath CodeDir  => Root.CodeDir;

        public FileExtension CodeExt => FileExtension.Define("hex");

        public FileName CodeFileName => BaseFileName + CodeExt;

        public FilePath CodePath => CodeDir + CodeFileName;

        public FolderPath DecodedDir  => Root.DecodedDir;
        
        public FileExtension DecodedExt => FileExtensions.Asm;
        
        public FileName DecodedFileName => BaseFileName + DecodedExt;

        public FilePath DecodedPath => DecodedDir + DecodedFileName;
    }
}