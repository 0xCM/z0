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

    public readonly struct EncodedHexArchive : IEncodedHexArchive
    {
        [MethodImpl(Inline)]
        public static IEncodedHexArchive Service(FolderPath root)
            => new EncodedHexArchive(root);

        public FolderPath ArchiveRoot {get;}            
        
        [MethodImpl(Inline)]
        internal EncodedHexArchive(FolderPath root)
            => ArchiveRoot = root;

        public IEnumerable<IdentifiedCode> Read(ApiHostUri host)
        {
            var hfn = ApiHostUri.HostFileName(host.Owner, host.Name, FileExtensions.Hex);
            var path = Files(host.Owner).Where(f => f.FileName == hfn).FirstOrDefault(FilePath.Empty);

            foreach(var item in Read(path))   
                if(item.IsNonEmpty)
                    yield return item;
        }

        public IEnumerable<FilePath> Files() 
            => ArchiveRoot.Files(FileExtensions.Hex, true);

        public IEnumerable<FilePath> Files(PartId owner) 
            => ArchiveRoot.Files(owner, FileExtensions.Hex, true);

        public IEnumerable<IdentifiedCodeIndex> ReadIndices(params PartId[] owners)     
        {
            if(owners.Length != 0)
            {
                foreach(var owner in owners)            
                foreach(var file in Files(owner))
                {
                    var index = ReadIndex(file);
                    if(index)
                        yield return index.Value;
                }
            }  
            else
            {
                foreach(var file in Files())
                {                    
                    var index = ReadIndex(file);
                    if(index)
                        yield return index.Value;
                }
            }          
        }

        public Option<IdentifiedCodeIndex> ReadIndex(FilePath file)
        {
            var uri = ApiHostUri.Parse(file.FileName).ValueOrDefault(ApiHostUri.Empty);                
            if(uri.IsNonEmpty)
            {
                var dst = Root.list<IdentifiedCode>();
                foreach(var item in Read(file))
                    if(item.IsNonEmpty)
                        dst.Add(item);
                return new IdentifiedCodeIndex(uri, dst.ToArray());            
            }
            return Option.none<IdentifiedCodeIndex>();
        }

        public IEnumerable<IdentifiedCode> Read()
            => Read(_ => true);

        public IEnumerable<IdentifiedCode> Read(PartId owner)
        {
            foreach(var file in Files(owner))
            foreach(var item in Read(file))
                if(item.IsNonEmpty)
                    yield return item;
        }

        public IEnumerable<IdentifiedCode> Read(Func<FileName,bool> predicate)
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
        public IEnumerable<IdentifiedCode> Read(FilePath src)
            => EncodedHexReader.Service.Read(src);

        /// <summary>
        /// Reads a moniker-identified, default-formatted hex-line file
        /// </summary>
        /// <param name="id">The identifying moniker</param>
        public IEnumerable<IdentifiedCode> Read(OpIdentity id)
            => Read(ArchiveRoot + FileName.Define(id, FileExtensions.Hex));        
    }
}