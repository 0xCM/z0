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

    public readonly struct ApiHexArchive : IApiHexArchive<ApiHexArchive>
    {
        public FolderPath ArchiveRoot {get;}

        IMultiSink Sink {get;}

        [MethodImpl(Inline)]
        public ApiHexArchive(FolderPath root)
        {
            ArchiveRoot = root;
            Sink = new TermEventSink();
        }

        [MethodImpl(Inline)]
        public ApiHexArchive(FS.FolderPath root)
        {
            ArchiveRoot = FolderPath.Define(root.Name);
            Sink = new TermEventSink();
        }

        public static FilePath[] files(FolderPath root, PartId owner)
            => root.Files(owner, FileExtensions.HexLine, true).Array();

        public static FilePath[] files(FolderPath root)
            => root.Files(FileExtensions.HexLine, true).Array();

        public static ApiHex[] read(FilePath src)
            => ApiHexReader.Service.Read(src).Where(x => x.IsNonEmpty);

        public static ApiHex[] read(FolderPath root, ApiHostUri host)
        {
            var hfn = FileName.define(host.Owner, host.Name, FileExtensions.HexLine);
            var path = files(root).Where(f => f.FileName == hfn).FirstOrDefault(FilePath.Empty);
            return read(path);
        }

        public static ApiHexIndex index(FilePath src, IMultiSink status)
        {
            var uri = ApiUriParser.host(src.FileName);
            if(uri.Failed || uri.Value.IsEmpty)
            {
                status.Deposit(AppErrors.define(nameof(ApiHexArchive), uri.Reason));
                return ApiHexIndex.Empty;
            }

            var dst = z.list<ApiHex>();
            foreach(var item in read(src))
                if(item.IsNonEmpty)
                    dst.Add(item);

            return Encoded.index(uri.Value, dst.Array());
        }

        public IEnumerable<ApiHex> Read(ApiHostUri host)
        {
            var hfn = FileName.define(host.Owner, host.Name, FileExtensions.HexLine);
            var path = Files(host.Owner).Where(f => f.FileName == hfn).FirstOrDefault(FilePath.Empty);
            return read(ArchiveRoot,host);
        }

        public IEnumerable<FilePath> Files()
            => ArchiveRoot.Files(FileExtensions.HexLine, true);

        public IEnumerable<FilePath> Files(PartId owner)
            => ArchiveRoot.Files(owner, FileExtensions.HexLine, true);

        public IEnumerable<ApiHexIndex> ReadIndices(params PartId[] owners)
        {
            if(owners.Length != 0)
            {
                foreach(var owner in owners)
                foreach(var file in Files(owner))
                {
                    var idx = index(file, Sink);
                    if(idx.IsNonEmpty)
                        yield return idx;
                }
            }
            else
            {
                foreach(var file in Files())
                {
                    var idx = index(file, Sink);
                    if(idx.IsNonEmpty)
                        yield return idx;
                }
            }
        }

        public ApiHexIndex ReadIndex(FilePath file)
            => index(file, Sink);

        public IEnumerable<ApiHex> Read()
            => Read(_ => true);

        public IEnumerable<ApiHex> Read(PartId owner)
        {
            foreach(var file in Files(owner))
            foreach(var item in Read(file))
                if(item.IsNonEmpty)
                    yield return item;
        }

        public IEnumerable<ApiHex> Read(Func<FileName,bool> predicate)
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
        /// <param name="bytesep">The hex byte delimiter</param>
        public IEnumerable<ApiHex> Read(FilePath src)
            => ApiHexReader.Service.Read(src);

        /// <summary>
        /// Reads a moniker-identified, default-formatted hex-line file
        /// </summary>
        /// <param name="id">The identifying moniker</param>
        public IEnumerable<ApiHex> Read(OpIdentity id)
            => Read(ArchiveRoot + FileName.define(id, FileExtensions.HexLine));
    }
}