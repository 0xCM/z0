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

    public readonly struct HostAsmArchiver : IHostAsmArchiver
    {
        public PartId Owner => Host.Owner;

        public ApiHostUri Host {get;}

        public FolderPath ArchiveRoot {get;}

        readonly IAsmFormatter AsmFormatter;

        readonly ICilFunctionFormatter CilFormatter;

        readonly IHostCapturePaths HostArchive;

        [MethodImpl(Inline)]
        public HostAsmArchiver(ApiHostUri host, IAsmFormatter formatter, FolderPath root)
        {
            Host = host;
            ArchiveRoot = root;
            AsmFormatter = formatter;
            HostArchive = HostCaptureArchive.create(root, host);
            CilFormatter =  AsmCore.Services.CilFormatter();
        }

        public Option<FilePath> SaveAsm(AsmRoutine[] src, bool append)
        {
            try
            {
                var dst = HostArchive.HostAsmPath;
                using var writer = new StreamWriter(dst.FullPath, append);
                for(var i=0; i<src.Length; i++)
                {
                    ref readonly var f = ref src[i];
                    if(f.IsNonEmpty)
                        writer.Write(AsmFormatter.FormatFunction(f));
                }
                return dst;
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<FilePath>();
            }
        }

        public Option<FilePath> SaveAsmImm(OpIdentity id, AsmRoutine[] src, bool append)
        {
            var dst = HostArchive.AsmImmPath(Host.Owner, Host, id);
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
            var pad = src.Select(f => f.OpId.Identifier.Length).Max() + 1;
            var dst = HostArchive.HexImmPath(Host.Owner, Host, id);
            using var writer = dst.Writer();
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var f = ref src[i];
                if(f.IsNonEmpty)
                    writer.WriteLine(f.Code.Format(pad));
            }
            return dst;
        }
    }
}