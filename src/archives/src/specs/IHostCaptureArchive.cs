//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IHostCaptureArchive : ICaptureArchive
    {
        ICaptureArchive Parent {get;}        

        ApiHostUri HostUri {get;}

        FolderPath ICaptureArchive.RootDir => Parent.RootDir;

        FileName BaseFileName => FileName.Define(text.concat(HostUri.Owner.Format(), text.dot(),  HostUri.Name));

        FileName ExtractFileName => BaseFileName + ExtractExt;

        new FilePath ExtractPath => ExtractDir + ExtractFileName;

        FileName ParsedFileName => BaseFileName + ParsedExt;

        new FileName HexFileName => BaseFileName + HexExt;

        FilePath ParsedPath => Parent.ParsedDir + ParsedFileName;

        new FilePath HexPath => Parent.HexDir + HexFileName;

        FileName AmsFileName => BaseFileName + AsmExt;

        new FilePath AsmPath => Parent.AsmDir + AmsFileName;         

        new FileName CilFileName
            => FileName.Define(text.concat(HostUri.Owner.Format(), text.dot(), HostUri.Name), CilExt);
    }
}