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

    readonly struct OperationalArchive : IOperationalArchive
    {
        public FolderPath ArchiveRoot {get;}            

        [MethodImpl(Inline)]
        public OperationalArchive(FolderPath root)
        {
            this.ArchiveRoot = root;
        }

        public IEnumerable<OperationBits> ReadHex(ApiHostUri host)
        {
            var hfn = FileName.Define($"{host.Owner.Format()}.{host.Name}", FileExtensions.Hex);
            var path = List(host.Owner).Where(f => f.FileName == hfn).FirstOrDefault(FilePath.Empty);
            if(path.Exists())
            {
                foreach(var item in ReadHex(path))   
                {
                    if(item.IsNonEmpty)
                        yield return item;
                }
            }
        }

        IBitArchiveReader BitArchives
            => BitArchiveReader.Service;

        /// <summary>
        /// Enumerates the archived files that are owned by a specified part
        /// </summary>
        /// <param name="owner">The owning paret</param>
        public IEnumerable<FilePath> List(PartId owner) 
            => ArchiveRoot.Files(owner, FileExtensions.Hex, true);

        /// <summary>        
        /// Reads a hex data file
        /// </summary>
        /// <param name="src">The source file path</param>
        public IEnumerable<OperationBits> ReadHex(FilePath src)
            =>  BitArchives.Read(src);
    }
}