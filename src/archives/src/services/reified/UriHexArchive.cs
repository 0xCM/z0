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

    using static Konst;

    public readonly struct UriHexArchive : IUriHexArchive
    {
        public FolderPath ArchiveRoot {get;}            

        [MethodImpl(Inline)]
        public static IUriHexArchive Create(FolderPath root)
            => new UriHexArchive(root);
        
        [MethodImpl(Inline)]
        internal UriHexArchive(FolderPath root)
            => ArchiveRoot = root;

        public IEnumerable<UriHex> Read(ApiHostUri host)
        {
            var hfn = FileName.Define($"{host.Owner.Format()}.{host.Name}", FileExtensions.Hex);
            var path = Files(host.Owner).Where(f => f.FileName == hfn).FirstOrDefault(FilePath.Empty);
            if(path.Exists)
            {
                foreach(var item in Read(path))   
                {
                    if(item.IsNonEmpty)
                        yield return item;
                }
            }
        }

        public IEnumerable<FilePath> Files() 
            => ArchiveRoot.Files(FileExtensions.Hex, true);

        public IEnumerable<FilePath> Files(PartId owner) 
            => ArchiveRoot.Files(owner, FileExtensions.Hex, true);
        
        public IEnumerable<UriHex> Read()
            => Read(_ => true);

        public IEnumerable<UriHex> Read(PartId owner)
        {
            foreach(var file in Files(owner))
            foreach(var item in Read(file))
                if(item.IsNonEmpty)
                    yield return item;
        }

        public IEnumerable<UriHex> Read(Func<FileName,bool> predicate)
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
        public IEnumerable<UriHex> Read(FilePath src)
            => UriHexReader.Service.Read(src);

        /// <summary>
        /// Reads a moniker-identified, default-formatted hex-line file
        /// </summary>
        /// <param name="id">The identifying moniker</param>
        public IEnumerable<UriHex> Read(OpIdentity id)
            => Read(ArchiveRoot + FileName.Define(id, FileExtensions.Hex));        
    }
}