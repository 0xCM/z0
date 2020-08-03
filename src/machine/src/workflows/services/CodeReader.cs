//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    public readonly struct CodeReader
    {
        public static IEnumerable<IdentifiedCodeIndex> identified(FolderPath src, IWfEventSink sink, params PartId[] owners)     
        {
            if(owners.Length != 0)
            {
                foreach(var owner in owners)            
                foreach(var file in Files(src, owner))
                {
                    var idx = index(file, sink);
                    if(idx.IsNonEmpty)
                        yield return idx;
                }
            }  
            else
            {
                foreach(var file in Files(src))
                {                    
                    var idx = index(file, sink);
                    if(idx.IsNonEmpty)
                        yield return idx;
                }
            }          
        }

        public static IEnumerable<FilePath> Files(FolderPath src) 
            => src.Files(FileExtensions.Hex, true);

        public static IEnumerable<FilePath> Files(FolderPath src, PartId owner) 
            => src.Files(owner, FileExtensions.Hex, true);

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

        static IdentifiedCodeIndex index(FilePath src, IAppEventSink status)
        {
            var uri = ApiHostUri.Parse(src.FileName);
            if(uri.Failed || uri.Value.IsEmpty)
            {
                status.Deposit(Events.error(uri.Reason));
                return IdentifiedCodeIndex.Empty;
            }

            var dst = z.list<IdentifiedCode>();                
            foreach(var item in read(src))
                if(item.IsNonEmpty)
                    dst.Add(item);
            
            return Encoded.index(uri.Value, dst.Array());                        
        }
    }
}