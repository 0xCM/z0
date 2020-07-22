//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct HostArchiver : IHostArchiver
    {                
        public PartId Owner => Host.Owner;

        public ApiHostUri Host {get;}

        public FolderPath ArchiveRoot {get;}

        readonly IAsmFormatter AsmFormatter;

        readonly ICilFunctionFormatter CilFormatter;

        readonly THostCaptureArchive HostArchive;

        [MethodImpl(Inline)]
        internal HostArchiver(ApiHostUri host, IAsmFormatter formatter, FolderPath root)
        {
            Host = host;
            ArchiveRoot = root;
            AsmFormatter = formatter;
            HostArchive = HostCaptureArchive.create(root, host);
            CilFormatter =  AsmCore.Services.CilFormatter();
        }
        
        public Option<FilePath> SaveHex(AsmFunction[] src, bool append)    
        {
            try
            {
                var idpad = src.Select(f => f.OpId.Identifier.Length).Max() + 1;
                var dst = HostArchive.HexPath;
                using var writer = Archives.Services.IdentifiedCodeWriter(dst);
                for(var i=0; i<src.Length; i++)
                {
                    ref readonly var f = ref src[i];
                    if(f.IsNonEmpty)
                        writer.WriterLine(f.Code);
                }
                return dst;
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<FilePath>();
            }
        }

        public Option<FilePath> SaveAsm(AsmFunction[] src, bool append)
        {            
            try
            {
                var idpad = src.Select(f => f.OpId.Identifier.Length).Max() + 1;
                var dst = HostArchive.AsmPath;
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

        public Option<FilePath> SaveAsmImm(OpIdentity id, AsmFunction[] src, bool append)
        {
            var idpad = src.Select(f => f.OpId.Identifier.Length).Max() + 1;
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

        public Option<FilePath> SaveHexImm(OpIdentity id, AsmFunction[] src, bool append)
        {
            var idpad = src.Select(f => f.OpId.Identifier.Length).Max() + 1;
            var dst = HostArchive.HexImmPath(Host.Owner, Host, id);
            using var writer = dst.Writer();
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var f = ref src[i];
                if(f.IsNonEmpty)
                    writer.WriteLine(f.Code.Format(idpad));
            }
            return dst;
        }
    }
}