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

    using static Seed;

    public readonly struct HostAsmArchiver : IHostAsmArchiver
    {                
        public PartId Owner {get;}

        public ApiHostUri ApiHost {get;}
    
        readonly IAsmFormatter AsmFormatter;

        readonly ICilFunctionFormatter CilFormatter;

        readonly IHostCaptureArchive HostArchive;


        internal HostAsmArchiver(ApiHostUri host, IAsmFormatter formatter, FolderPath dst)
        {
            ApiHost = host;
            Owner = host.Owner;
            AsmFormatter = formatter;
            HostArchive = CreateHostArchive(ApiHost,dst);
            CilFormatter =  AsmCore.Services.CilFormatter();
        }
        
        internal HostAsmArchiver(PartId part, string hostname, IAsmFormatter formatter)
        {
            Owner = part;
            AsmFormatter = formatter;
            ApiHost = ApiHostUri.Define(part, hostname);
            HostArchive = CreateHostArchive(ApiHost);
            CilFormatter =  AsmCore.Services.CilFormatter();
        }

        static IHostCaptureArchive CreateHostArchive(ApiHostUri host, FolderPath dst = null)
            => Archives.Services.HostCaptureArchive(Archives.Services.CaptureArchive(dst), host);

        public Option<FilePath> SaveHex(AsmFunction[] src, bool append)    
        {
            try
            {
                var idpad = src.Select(f => f.OpId.Identifier.Length).Max() + 1;
                var dst = HostArchive.HexPath;
                using var writer = new StreamWriter(dst.FullPath, append);                
                for(var i=0; i<src.Length; i++)
                {
                    ref readonly var f = ref src[i];
                    if(f.IsNonEmpty)
                        writer.WriteLine(f.Code.Format(idpad));
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

        public Option<FilePath> SaveInjectedImmAsm(OpIdentity id, AsmFunction[] src, bool append)
        {
            var idpad = src.Select(f => f.OpId.Identifier.Length).Max() + 1;
            var dst = HostArchive.AsmImmPath(ApiHost.Owner, ApiHost, id);
            using var writer = dst.Writer();
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var f = ref src[i];
                if(f.IsNonEmpty)
                    writer.Write(AsmFormatter.FormatFunction(f));
            }
            return dst;
        }

        public Option<FilePath> SaveInjectedImmHex(OpIdentity id, AsmFunction[] src, bool append)
        {
            var idpad = src.Select(f => f.OpId.Identifier.Length).Max() + 1;
            var dst = HostArchive.HexImmPath(ApiHost.Owner, ApiHost, id);
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