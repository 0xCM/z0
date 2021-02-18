//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmImmWriter : IAsmImmWriter
    {
        public ApiHostUri Uri {get;}

        public FS.FolderPath ImmRoot {get;}

        readonly IAsmFormatter AsmFormatter;

        readonly ICilFunctionFormatter CilFormatter;

        readonly IApiHostPaths HostArchive;

        [MethodImpl(Inline)]
        public AsmImmWriter(ApiHostUri host, IAsmFormatter formatter, FS.FolderPath root)
        {
            Uri = host;
            ImmRoot = root;
            AsmFormatter = formatter;
            HostArchive = ApiArchives.host(FS.dir(root.Name), host);
            CilFormatter =  Cil.formatter();
        }

        public Option<FS.FilePath> SaveAsmImm(OpIdentity id, AsmRoutine[] src, bool append)
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

        public Option<FS.FilePath> SaveHexImm(OpIdentity id, AsmRoutine[] src, bool append)
        {
            var path = HostArchive.HexImmPath(Uri.Owner, Uri, id);
            ApiCodeExtracts.emit(src.Map(x => x.Code), FS.path(path.Name),append);
            return path;
        }
    }
}