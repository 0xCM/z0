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

    public class HostAsmArchiver : IHostAsmArchiver
    {                
        public PartId DefiningPart {get;}

        public ApiHostUri ApiHost {get;}
    
        readonly IAsmFormatter AsmFormatter;

        readonly ICilFunctionFormatter CilFormatter;

        readonly IHostCaptureArchive HostArchive;

        readonly bool Imm;

        [MethodImpl(Inline)]
        public static IHostAsmArchiver ImmArchive(IContext context, ApiHostUri host, IAsmFormatter formatter, FolderPath dst)
            => new HostAsmArchiver(context, host, true, formatter, dst);

        [MethodImpl(Inline)]
        public static IHostAsmArchiver Create(IContext context, PartId catalog, string host, IAsmFormatter formatter)
            => new HostAsmArchiver(context, catalog, host, formatter);

        HostAsmArchiver(IContext context, ApiHostUri host, bool imm, IAsmFormatter formatter, FolderPath dst)
        {
            this.Imm = true;
            this.HostArchive = HostCaptureArchive.Define(CaptureArchive.Define(dst), host);
            this.DefiningPart = host.Owner;
            this.ApiHost = host;
            this.AsmFormatter = formatter;
            this.CilFormatter = context.CilFormatter();
        }
        
        HostAsmArchiver(IContext context, PartId part, string hostname, IAsmFormatter formatter)
        {
            this.Imm = false;
            this.HostArchive = HostCaptureArchive.Define(CaptureArchive.Define(), ApiHostUri.Define(part, hostname));
            this.DefiningPart = part;
            this.ApiHost = ApiHostUri.Define(part, hostname);
            this.AsmFormatter = formatter;
            this.CilFormatter = context.CilFormatter();
        }

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
            => SaveHex(src.Members,append);

        Option<FilePath> SaveAsm(AsmFunctionGroup src, bool append)
            => SaveAsm(src.Members, append);
    }
}