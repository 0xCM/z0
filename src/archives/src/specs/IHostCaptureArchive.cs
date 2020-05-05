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

        public FolderPath ArchiveRoot {get;}

        public FolderPath[] Clear(params PartId[] parts)
        {
            return Arrays.empty<FolderPath>();
        }

        [MethodImpl(Inline)]
        internal HostCaptureArchive(FolderPath root, ApiHostUri host)
        {
            Host = host;
            ArchiveRoot = root;
        }    
    }
    
    public interface IHostCaptureArchive : ICaptureArchive
    {
        ApiHostUri Host {get;}

        FileName ExtractFileName 
            => LegalFileName(Host, Extract);

        new FilePath ExtractPath 
            => ExtractDir + ExtractFileName;

        FileName ParsedFileName 
            => LegalFileName(Host, Parsed);

        FilePath ParsedPath 
            => ParsedDir + ParsedFileName;

        new FileName HexFileName 
            => LegalFileName(Host, Hex);

        new FilePath HexPath 
            => CodeDir + HexFileName;

        FileName AmsFileName 
            => LegalFileName(Host, Asm);

        new FilePath AsmPath 
            => AsmDir + AmsFileName;         

        new FileName CilFileName
            => LegalFileName(Host, Il);
    }
}