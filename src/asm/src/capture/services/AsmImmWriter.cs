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
        public IWfShell Wf {get;}

        public ApiHostUri Uri {get;}

        public FS.FolderPath ImmRoot {get;}

        readonly IAsmFormatter AsmFormatter;

        readonly ICilFunctionFormatter CilFormatter;

        readonly IApiPathProvider Paths;

        [MethodImpl(Inline)]
        public AsmImmWriter(IWfShell wf, ApiHostUri host, IAsmFormatter formatter, FS.FolderPath root)
        {
            Wf = wf;
            Uri = host;
            ImmRoot = root;
            AsmFormatter = formatter;
            CilFormatter =  Cil.formatter();
            Paths = ApiArchives.paths(wf);
        }

        public Option<FS.FilePath> SaveAsmImm(OpIdentity id, AsmRoutine[] src, bool append, bool refined)
        {
            var dst = Paths.AsmImmPath(Uri.Owner, Uri, id, refined);
            using var writer = dst.Writer(append);
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var f = ref src[i];
                if(f.IsNonEmpty)
                    writer.Write(AsmFormatter.FormatFunction(f));
            }
            return dst;
        }

        public Option<FS.FilePath> SaveHexImm(OpIdentity id, AsmRoutine[] src, bool append, bool refined)
        {
            var path = Paths.HexImmPath(Uri.Owner, Uri, id, refined);
            var code = src.Map(x => x.Code);
            ApiCode.emit(Wf, Uri, code, path, append);
            return path;
        }
    }
}