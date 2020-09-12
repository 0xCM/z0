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

        public static X86UriHex[] read(FilePath src)
            => ApiHexReader.Service.Read(src).Where(x => x.IsNonEmpty);

        public static X86UriHex[] read(FolderPath root, ApiHostUri host)
        {
            var hfn = FileName.define(host.Owner, host.Name, FileExtensions.HexLine);
            var path = files(root).Where(f => f.FileName == hfn).FirstOrDefault(FilePath.Empty);
            return read(path);
        }

        public static X86UriIndex index(FilePath src, IMultiSink status)
        {
            var uri = ApiUriParser.host(src.FileName);
            if(uri.Failed || uri.Value.IsEmpty)
            {
                status.Deposit(AppErrors.define(nameof(ApiHexArchive), uri.Reason));
                return X86UriIndex.Empty;
            }

            var dst = z.list<X86UriHex>();
            foreach(var item in read(src))
                if(item.IsNonEmpty)
                    dst.Add(item);

            return Encoded.index(uri.Value, dst.Array());
        }

        public IEnumerable<X86UriHex> Read(ApiHostUri host)
        {
            var hfn = FileName.define(host.Owner, host.Name, FileExtensions.HexLine);
            var path = Files(host.Owner).Where(f => f.FileName == hfn).FirstOrDefault(FilePath.Empty);
            return read(ArchiveRoot,host);
        }

        public IEnumerable<FilePath> Files()
            => ArchiveRoot.Files(FileExtensions.HexLine, true);

        public IEnumerable<FilePath> Files(PartId owner)
            => ArchiveRoot.Files(owner, FileExtensions.HexLine, true);

        public IEnumerable<X86UriIndex> ReadIndices(params PartId[] owners)
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

        public X86UriIndex ReadIndex(FilePath file)
            => index(file, Sink);

        public IEnumerable<X86UriHex> Read()
            => Read(_ => true);

        public IEnumerable<X86UriHex> Read(PartId owner)
        {
            foreach(var file in Files(owner))
            foreach(var item in Read(file))
                if(item.IsNonEmpty)
                    yield return item;
        }

        public IEnumerable<X86UriHex> Read(Func<FileName,bool> predicate)
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
        public IEnumerable<X86UriHex> Read(FilePath src)
            => ApiHexReader.Service.Read(src);

        /// <summary>
        /// Reads a moniker-identified, default-formatted hex-line file
        /// </summary>
        /// <param name="id">The identifying moniker</param>
        public IEnumerable<X86UriHex> Read(OpIdentity id)
            => Read(ArchiveRoot + FileName.define(id, FileExtensions.HexLine));
    }
}