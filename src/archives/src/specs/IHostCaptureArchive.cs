//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// A host-specific capture archive
    /// </summary>
    public readonly struct HostCaptureArchive : IHostCaptureArchive
    {                                        
        [MethodImpl(Inline)]
        public static IHostCaptureArchive Create(FolderPath root, ApiHostUri host)
            => new HostCaptureArchive(root,host);

        public ApiHostUri Host {get;}

        public FolderPath RootDir {get;}

        public FolderPath[] Clear(params PartId[] parts)
        {
            return Arrays.empty<FolderPath>();
        }

        [MethodImpl(Inline)]
        internal HostCaptureArchive(FolderPath root, ApiHostUri host)
        {
            Host = host;
            RootDir = root;
        }    
    }
    
    public interface IHostCaptureArchive : ICaptureArchive
    {
        ApiHostUri Host {get;}

        FileName ExtractFileName 
            => HostFileName(Host, ExtractExt);

        new FilePath ExtractPath 
            => ExtractDir + ExtractFileName;

        FileName ParsedFileName 
            => HostFileName(Host, ParsedExt);

        FilePath ParsedPath 
            => ParsedDir + ParsedFileName;

        new FileName HexFileName 
            => HostFileName(Host, HexExt);

        new FilePath HexPath 
            => HexDir + HexFileName;

        FileName AmsFileName 
            => HostFileName(Host, AsmExt);

        new FilePath AsmPath 
            => AsmDir + AmsFileName;         

        new FileName CilFileName
            => HostFileName(Host, CilExt);
    }
}