//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IApiHostArchive : ICodeArchive
    {
        IApiCodeArchive Parent {get;}        

        ApiHostUri HostUri {get;}

        FolderPath ExtractDir => Parent.ExtractDir;

        FileName BaseFileName => FileName.Define(text.concat(HostUri.Owner.Format(), text.dot(),  HostUri.Name));

        FileName ExtractFileName => BaseFileName + ExtractExt;

        FilePath ExtractPath => ExtractDir + ExtractFileName;

        FileName ParsedFileName => BaseFileName + ParsedExt;

        FileName HexFileName => BaseFileName + HexExt;

        FilePath ParsedPath => Parent.ParsedDir + ParsedFileName;

        FilePath HexPath => Parent.HexDir + HexFileName;

        FileName DecodedFileName => BaseFileName + AsmExt;

        FilePath DecodedPath => Parent.DecodedDir + DecodedFileName;         

        FileName CilFileName
            => FileName.Define(text.concat(HostUri.Owner.Format(), text.dot(), HostUri.Name), CilExt);
    }

    public readonly struct ApiHostArchive : IApiHostArchive
    {
        public IApiCodeArchive Parent {get;}
                
        public ApiHostUri HostUri {get;}

        [MethodImpl(Inline)]
        public static IApiHostArchive Define(IApiCodeArchive root, in ApiHostUri host)
            => new ApiHostArchive(root,host);

        [MethodImpl(Inline)]
        ApiHostArchive(IApiCodeArchive root, in ApiHostUri host)
        {
            this.HostUri = host;
            this.Parent = root;
        }    
    }
}