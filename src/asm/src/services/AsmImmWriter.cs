//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmImmWriter : IAsmImmWriter
    {
        public ApiHostUri Uri {get;}

        public FolderPath ArchiveRoot {get;}

        readonly IAsmFormatter AsmFormatter;

        readonly ICilFunctionFormatter CilFormatter;

        readonly IHostCapturePaths HostArchive;

        [MethodImpl(Inline)]
        public AsmImmWriter(ApiHostUri host, IAsmFormatter formatter, FolderPath root)
        {
            Uri = host;
            ArchiveRoot = root;
            AsmFormatter = formatter;
            HostArchive = ApiArchives.capture(FS.dir(root.Name), host);
            CilFormatter =  Cil.formatter();
        }

        public Option<FilePath> SaveAsmImm(OpIdentity id, AsmRoutine[] src, bool append)
        {
            var dst = HostArchive.AsmImmPath(Uri.Owner, Uri, id);
            using var writer = dst.Writer();
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var f = ref src[i];
                if(f.IsNonEmpty)
                    writer.Write(AsmFormatter.FormatFunction(f));
            }
            return dst;
        }

        public Option<FilePath> SaveHexImm(OpIdentity id, AsmRoutine[] src, bool append)
        {
            var path = HostArchive.HexImmPath(Uri.Owner, Uri, id);
            ApiArchives.save(src.Map(x => x.Code), FS.path(path.Name),append);
            return path;
        }
    }
}