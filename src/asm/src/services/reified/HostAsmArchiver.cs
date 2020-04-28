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

        readonly bool Imm;

        internal HostAsmArchiver(ApiHostUri host, bool imm, IAsmFormatter formatter, FolderPath dst)
        {
            Imm = true;
            ApiHost = host;
            Owner = host.Owner;
            AsmFormatter = formatter;
            HostArchive = CreateHostArchive(ApiHost,dst);
            CilFormatter =  AsmCore.Services.CilFormatter();
        }
        
        internal HostAsmArchiver(PartId part, string hostname, IAsmFormatter formatter)
        {
            Imm = false;
            Owner = part;
            AsmFormatter = formatter;
            ApiHost = ApiHostUri.Define(part, hostname);
            HostArchive = CreateHostArchive(ApiHost);
            CilFormatter =  AsmCore.Services.CilFormatter();
        }

        static IHostCaptureArchive CreateHostArchive(ApiHostUri host, FolderPath dst = null)
            => Archives.Services.HostCaptureArchive(Archives.Services.CaptureArchive(dst), host);

        public void Save(AsmFunctionGroup src, bool append)
        {            
            SaveHex(src, append);
            SaveAsm(src, append);
        }

        public void Clear()
        {
            
        }

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

        Option<FilePath> SaveHex(AsmFunctionGroup src, bool append)
            => SaveHex(src.Id, src.Members,append);

        Option<FilePath> SaveAsm(AsmFunctionGroup src, bool append)
            => SaveAsm(src.Id, src.Members, append);

        public Option<FilePath> SaveAsm(OpIdentity id, AsmFunction[] src, bool append)
        {
            var idpad = src.Select(f => f.OpId.Identifier.Length).Max() + 1;
            var dst = Imm ? HostArchive.AsmImmPath(ApiHost.Owner, ApiHost, id) : HostArchive.AsmPath;
            using var writer = dst.Writer();
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var f = ref src[i];
                if(f.IsNonEmpty)
                    writer.Write(AsmFormatter.FormatFunction(f));
            }
            return dst;
        }

        public Option<FilePath> SaveHex(OpIdentity id, AsmFunction[] src, bool append)
        {
            var idpad = src.Select(f => f.OpId.Identifier.Length).Max() + 1;
            var dst = Imm ? HostArchive.HexImmPath(ApiHost.Owner, ApiHost, id) : HostArchive.HexPath;
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