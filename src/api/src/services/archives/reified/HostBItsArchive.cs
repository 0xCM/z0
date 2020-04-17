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
        public FolderPath RootFolder {get;}

        readonly IBitArchiveReader ArchiveReader;
        
        public PartId DefiningPart {get;}

        public ApiHostUri ApiHost {get;}
        
        [MethodImpl(Inline)]
        public static IHostBitsArchive Create(IContext context, PartId catalog, FolderPath root)
            => new HostBitsArchive(context, catalog, root);

        [MethodImpl(Inline)]
        public static IHostBitsArchive Create(IContext context, PartId catalog, ApiHostUri host, FolderPath root)
            => new HostBitsArchive(context, catalog, host, root);

        [MethodImpl(Inline)]
        HostBitsArchive(IContext context, PartId catalog, ApiHostUri host, FolderPath root)
        {
            this.DefiningPart = catalog;
            this.ApiHost = host;
            this.RootFolder = root;
            this.ArchiveReader = context.BitArchiveReader();
        }

        HostBitsArchive(IContext context, PartId catalog, FolderPath root)
        {
            this.DefiningPart = catalog;
            this.ApiHost = ApiHostUri.Empty;
            this.RootFolder = root;
            this.ArchiveReader = context.BitArchiveReader();
        }

        /// <summary>
        /// Enumerates the files in the archive
        /// </summary>
        IEnumerable<FilePath> Files 
            => RootFolder.Files(FileExtensions.Hex,true);
                    
        public IEnumerable<LocatedBits> Read(string name)
            => Read(fn => fn.NoExtension == name);
        
        public IEnumerable<LocatedBits> Read()
            => Read(_ => true);

        public IEnumerable<LocatedBits> Read(Func<FileName,bool> predicate)
        {
            foreach(var file in Files.Where(f => predicate(f.FileName)))
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
        public IEnumerable<LocatedBits> Read(FilePath src)
            => ArchiveReader.Read(src);

        /// <summary>
        /// Reads a moniker-identified, default-formatted hex-line file
        /// </summary>
        /// <param name="id">The identifying moniker</param>
        public IEnumerable<LocatedBits> Read(OpIdentity id)
            => Read(RootFolder + FileName.Define(id, EncodedHexLine.FileExt));        
    }
}