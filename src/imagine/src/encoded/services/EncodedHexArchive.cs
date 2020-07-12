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
        public FolderPath ArchiveRoot {get;}            
        
        [MethodImpl(Inline)]
        public EncodedHexArchive(FolderPath root)
            => ArchiveRoot = root;

        public static FilePath[] files(FolderPath root, PartId owner) 
            => root.Files(owner, FileExtensions.Hex, true).Array();

        public static FilePath[] files(FolderPath root)
            => root.Files(FileExtensions.Hex, true).Array();

        public static IdentifiedCode[] read(FilePath src)
            => EncodedHexReader.Service.Read(src).Where(x => x.IsNonEmpty).Array();

        public static IdentifiedCode[] read(FolderPath root, ApiHostUri host)
        {
            var hfn = ApiHostUri.HostFileName(host.Owner, host.Name, FileExtensions.Hex);
            var path = files(root).Where(f => f.FileName == hfn).FirstOrDefault(FilePath.Empty);
            return read(path);
        }

        public static IdentifiedCodeIndex index(FilePath src)
        {
            try
            {
                var uri = ApiHostUri.Parse(src.FileName).ValueOrDefault(ApiHostUri.Empty);   
                var dst = Root.list<IdentifiedCode>();
                if(uri.IsNonEmpty)
                {
                    foreach(var item in read(src))
                        if(item.IsNonEmpty)
                            dst.Add(item);
                }
                return Encoded.index(uri, dst.Array());
            }
            catch(Exception e)
            {   
                term.error(e);
            }
            return IdentifiedCodeIndex.Empty;            
        }

        public static IEnumerable<IdentifiedCodeIndex> indices(FolderPath root)
        {
            foreach(var file in files(root))
            {                    
                var idx = index(file);
                if(idx.IsNonEmpty)
                    yield return idx;
            }
        }
        
        public static IEnumerable<IdentifiedCodeIndex> indices(FolderPath root, params PartId[] owners)     
        {
            if(owners.Length != 0)
            {
                foreach(var owner in owners)            
                foreach(var file in files(root, owner))
                {
                    var idx = index(file);
                    if(idx.IsNonEmpty)
                        yield return idx;
                }
            }  
            else
            {
                foreach(var file in files(root))
                {                    
                    var idx = index(file);
                    if(idx.IsNonEmpty)
                        yield return idx;
                }
            }          
        }

        public IEnumerable<IdentifiedCode> Read(ApiHostUri host)
        {
            var hfn = ApiHostUri.HostFileName(host.Owner, host.Name, FileExtensions.Hex);
            var path = Files(host.Owner).Where(f => f.FileName == hfn).FirstOrDefault(FilePath.Empty);
            return read(ArchiveRoot,host);
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
                    var idx = index(file);
                    if(idx.IsNonEmpty)
                        yield return idx;
                }
            }  
            else
            {
                foreach(var file in Files())
                {                    
                    var idx = index(file);
                    if(idx.IsNonEmpty)
                        yield return idx;
                }
            }          
        }


        public IdentifiedCodeIndex ReadIndex(FilePath file)
            => index(file);

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