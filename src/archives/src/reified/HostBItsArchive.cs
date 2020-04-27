//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct HostBitsArchive : IHostBitsArchive
    {
        public PartId Part {get;}

        public ApiHostUri Host {get;}

        public FolderPath ArchiveRoot {get;}            

        [MethodImpl(Inline)]
        public static IHostBitsArchive Create(PartId part, FolderPath root = null)
            => new HostBitsArchive(part, root);

        [MethodImpl(Inline)]
        public static IHostBitsArchive Create(PartId part, ApiHostUri host, FolderPath root = null)
            => new HostBitsArchive(part, host, root);

        [MethodImpl(Inline)]
        HostBitsArchive(PartId part, ApiHostUri host, FolderPath root)
        {
            this.Part = part;
            this.Host = host;
            this.ArchiveRoot = root ?? CaptureArchive.Default.RootDir;
        }

        HostBitsArchive(PartId catalog, FolderPath root)
        {
            this.Part = catalog;
            this.Host = ApiHostUri.Empty;
            this.ArchiveRoot = root ?? CaptureArchive.Default.RootDir;
        }

        public IEnumerable<FilePath> Files() 
            => ArchiveRoot.Files(FileExtensions.Hex, true);

        public IEnumerable<FilePath> Files(PartId owner) 
            => ArchiveRoot.Files(owner, FileExtensions.Hex, true);

        public IEnumerable<OperationBits> Read(string name)
            => Read(fn => fn.NoExtension == name);
        
        public IEnumerable<OperationBits> Read()
            => Read(_ => true);

        public IEnumerable<OperationBits> Read(PartId owner)
        {
            foreach(var file in Files(owner))
            foreach(var item in Read(file))
                if(item.IsNonEmpty)
                    yield return item;
        }

        public IEnumerable<OperationBits> Read(Func<FileName,bool> predicate)
        {
            foreach(var file in Files().Where(f => predicate(f.FileName)))
            foreach(var item in Read(file))
            {
                if(item.IsNonEmpty)
                    yield return item;
            }
        }

        /// <summary>        
        /// Reads a default-formatted hex-line file
        /// </summary>
        /// <param name="src">The source file path</param>
        /// <param name="idsep">The id delimiter</param>
        /// <param name="bytesep">The hex byte delimiter</param>
        public IEnumerable<OperationBits> Read(FilePath src)
            => BitArchiveReader.Service.Read(src);

        /// <summary>
        /// Reads a moniker-identified, default-formatted hex-line file
        /// </summary>
        /// <param name="id">The identifying moniker</param>
        public IEnumerable<OperationBits> Read(OpIdentity id)
            => Read(ArchiveRoot + FileName.Define(id, EncodedHexLine.FileExt));        
    }
}