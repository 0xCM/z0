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

    public readonly struct UriBitsArchive : IUriBitsArchive
    {
        public FolderPath ArchiveRoot {get;}            

        [MethodImpl(Inline)]
        public static IUriBitsArchive Create(FolderPath root)
            => new UriBitsArchive(root);
        
        [MethodImpl(Inline)]
        internal UriBitsArchive(FolderPath root)
        {
            ArchiveRoot = root;
        }

        public IEnumerable<UriBits> Read(ApiHostUri host)
        {
            var hfn = FileName.Define($"{host.Owner.Format()}.{host.Name}", FileExtensions.Hex);
            var path = Files(host.Owner).Where(f => f.FileName == hfn).FirstOrDefault(FilePath.Empty);
            if(path.Exists())
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
        
        public IEnumerable<UriBits> Read()
            => Read(_ => true);

        public IEnumerable<UriBits> Read(PartId owner)
        {
            foreach(var file in Files(owner))
            foreach(var item in Read(file))
                if(item.IsNonEmpty)
                    yield return item;
        }

        public IEnumerable<UriBits> Read(Func<FileName,bool> predicate)
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
        public IEnumerable<UriBits> Read(FilePath src)
            => UriBitsReader.Service.Read(src);

        /// <summary>
        /// Reads a moniker-identified, default-formatted hex-line file
        /// </summary>
        /// <param name="id">The identifying moniker</param>
        public IEnumerable<UriBits> Read(OpIdentity id)
            => Read(ArchiveRoot + FileName.Define(id, FileExtensions.Hex));        
    }
}