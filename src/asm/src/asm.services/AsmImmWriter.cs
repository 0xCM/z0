//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct AsmImmWriter : IAsmImmWriter
    {
        public IWfShell Wf {get;}

        public ApiHostUri Uri {get;}

        public FS.FolderPath ImmRoot {get;}

        readonly IWfDb Db;

        readonly IAsmRoutineFormatter Formatter;

        [MethodImpl(Inline)]
        public AsmImmWriter(IWfShell wf, ApiHostUri host, IAsmRoutineFormatter formatter)
        {
            Wf = wf;
            Uri = host;
            Db = Wf.Db();
            ImmRoot = Db.ImmRoot();
            Formatter = formatter;
        }

        public Option<FS.FilePath> SaveAsmImm(OpIdentity id, AsmRoutine[] src, bool append, bool refined)
        {
            var dst = Db.AsmImmPath(Uri.Owner, Uri, id, refined);
            using var writer = dst.Writer(append);
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var f = ref src[i];
                if(f.IsNonEmpty)
                    writer.Write(Formatter.Format(f));
            }
            return dst;
        }

        public ApiCodeset SaveHexImm(OpIdentity id, AsmRoutine[] src, bool append, bool refined)
        {
            if(src.Length == 0)
                return ApiCodeset.Empty;

            var path = Db.HexImmPath(Uri.Owner, Uri, id, refined);
            var count = src.Length;
            var view = @readonly(src);
            var blocks = alloc<ApiCodeBlock>(count);
            ref var block = ref first(blocks);
            using var writer = path.Writer(append);
            for(var i=0; i<count; i++)
            {
                var code = skip(view,i).Code;
                seek(block,i) = skip(view,i).Code;
                writer.WriteLine(string.Format("{0,-16} | {1,-80} | {2}", code.BaseAddress, code.Uri, code.Encoded.Format()));
            }
            return ApiCodeset.create(path, blocks);
        }
    }
}