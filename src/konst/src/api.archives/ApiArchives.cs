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

    [ApiHost]
    public readonly struct ApiArchives
    {
        [MethodImpl(Inline), Op]
        public static ApiPartCodeBlocks combine(PartId part, ApiHostCodeBlocks[] src)
            => new ApiPartCodeBlocks(part,src);

        [MethodImpl(Inline), Op]
        public static ApiHostCodeIndex index(ApiHostUri host, ApiCodeBlock[] code)
            => new ApiHostCodeIndex(host,code);

        public static Dictionary<PartId,PartFile[]> index(PartFileClass kind, PartFiles src, params PartId[] parts)
        {
            switch(kind)
            {
                case PartFileClass.Parsed:
                    return select(PartFileClass.Parsed, src.Parsed, parts);
                default:
                    return dict<PartId,PartFile[]>();
            }
        }

        public static ApiCodeBlock[] hex(FS.FilePath src)
            => from line in src.ReadLines().Select(ApiHexParser.row)
                where line.IsSome()
                select line.Value;

        static Dictionary<PartId,PartFile[]> select(PartFileClass kind, FS.Files src, PartId[] parts)
        {
            var partSet = parts.ToHashSet();
            var files = (from f in src
                        let part = f.Owner
                        where part != PartId.None && partSet.Contains(part)
                        let pf = new PartFile(part, kind, f)
                        group pf by pf.Part).ToDictionary(x => x.Key, y => y.ToArray());
            return files;
        }

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(FolderPath root)
            => new PartCaptureArchive(root ?? EnvVars.Common.LogRoot, FolderName.Empty, FolderName.Empty);

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(FS.FolderPath root)
            => new PartCaptureArchive(root);

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(PartId part)
            => new PartCaptureArchive(EnvVars.Common.LogRoot, FolderName.Define("capture"), FolderName.Define(part.Format()));

        [MethodImpl(Inline), Op]
        public static IPartCaptureArchive capture(ArchiveSettings config)
            => capture(FS.dir(config.Root.Name));

        public static PartFiles partfiles(FS.FolderPath root)
        {
            var src = capture(FolderPath.Define(root.Name));
            var parsed = src.ParsePaths.Select(x => FS.path(x.Name));
            var hex = src.HexPaths.Select(x => FS.path(x.Name));
            var asm = src.AsmPaths.Select(x => FS.path(x.Name));
            return new PartFiles(root, parsed, hex, asm);
        }

        [MethodImpl(Inline), Op]
        public static ApiCodeArchive hex(IWfShell wf)
            => new ApiCodeArchive(wf);

        [MethodImpl(Inline), Op]
        public static ApiCodeArchive hex(FS.FolderPath root)
            => new ApiCodeArchive(root);

        [MethodImpl(Inline), Op]
        public static ApiCodeBlock[] hex_data(IWfShell wf, ApiHostUri host)
            => hex(wf).Read(host);

        [MethodImpl(Inline)]
        public static ApiCodeWriter hexwriter<H>(FS.FilePath dst, H rep = default)
            where H : struct, IArchiveWriter<H>
        {
            if(typeof(H) == typeof(ApiCodeWriter))
                return new ApiCodeWriter(dst);
            else
                throw no<H>();
        }

        [MethodImpl(Inline)]
        public static IApiCodeReader hexreader<H>(H rep = default)
            where H : struct, IArchiveReader
        {
            if(typeof(H) == typeof(ApiCodeReader))
                return new ApiCodeReader();
            else
                throw no<H>();
        }
    }
}