//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static AsmServiceMessages;

    using static Root;

    class AsmFunctionArchive : IAsmFunctionArchive
    {        
        public static AppMsg Emitted(AsmCaptureTokenGroup src)
            => AppMsg.Info($"Emitted {src.Uri}");

        public FolderPath RootFolder {get;}
        
        public IAsmContext Context {get;}

        public AssemblyId Origin {get;}

        public string HostName {get;}

        public ApiHostPath HostPath {get;}

        readonly AsmFormatConfig GroupFormatConfig;

        readonly IAsmFunctionFormatter DefaultFormatter;

        readonly IAsmFunctionFormatter GroupFormatter;

        readonly ICilFunctionFormatter CilFormatter;

        AsmEmissionPaths EmissionPaths
            => Context.EmissionPaths();

        [MethodImpl(Inline)]
        public static IAsmFunctionArchive Create(IAsmContext context, AssemblyId catalog, string host)
            => new AsmFunctionArchive(context, catalog,host);

        [MethodImpl(Inline)]
        public static IAsmFunctionArchive Create(IAsmContext context, ApiHostPath host, bool imm)
            => new AsmFunctionArchive(context, host, imm);

        AsmFunctionArchive(IAsmContext context, ApiHostPath host, bool imm)
        {
            this.Context = context;
            this.Origin = host.Owner;
            this.HostName = $"{host.Name}-imm";
            this.HostPath = host;
            this.RootFolder = context.EmissionPaths().DataSubDir(RelativeLocation.Define(host.Owner.Format(), $"{host.Name}-imm"));
            this.DefaultFormatter = context.AsmFormatter();
            this.GroupFormatConfig = AsmFormatConfig.Default.WithSectionDelimiter().WithoutFunctionTimestamp().WithoutFunctionOrigin();
            this.GroupFormatter = context.WithFormat(GroupFormatConfig).AsmFormatter();
            this.CilFormatter = context.CilFormatter();
        }
        
        AsmFunctionArchive(IAsmContext context, AssemblyId catalog, string hostname)
        {
            this.Context = context;
            this.Origin = catalog;
            this.HostName = hostname;
            this.HostPath = ApiHostPath.Define(catalog, hostname);
            this.RootFolder = context.EmissionPaths().DataSubDir(RelativeLocation.Define(catalog.Format(), hostname));
            this.DefaultFormatter = context.AsmFormatter();
            this.GroupFormatConfig = AsmFormatConfig.Default.WithSectionDelimiter().WithoutFunctionTimestamp().WithoutFunctionOrigin();
            this.GroupFormatter = context.WithFormat(GroupFormatConfig).AsmFormatter();
            this.CilFormatter = context.CilFormatter();
        }

        public Option<AsmCaptureTokenGroup> Save(AsmFunctionGroup src, bool append)
        {            
            OnEmitting(src);
            WriteHex(src, append).OnSome(e => term.error(e));
            WriteCil(src, append).OnSome(e => term.error(e));            
            var emissions = WriteAsm(src,append);
            var incount = src.Members.Length;
            var outcount = emissions.MapValueOrDefault(t => t.Tokens.Length);
            if(incount != outcount)
               OnInOutMismatch(src.Id, incount, outcount);                
            
            return emissions.OnSome(OnEmitted);
        }

        public IAsmFunctionArchive Clear()
        {
            RootFolder.Clear();
            return this;
        }
            
        Option<Exception> WriteHex(AsmFunctionGroup src, bool append)
        {
            try
            {
                var idpad = src.Members.Select(f => f.Id.Identifier.Length).Max() + 1;
                using var writer = new StreamWriter(HexPath(src.Id).FullPath, append);
                foreach(var f in src.Members)
                    writer.WriteLine(f.Code.Format(idpad));
                return default;
            }
            catch(Exception e)
            {
                return e;
            }
        }

        Option<Exception> WriteCil(AsmFunctionGroup src, bool append)
        {
            try
            {                
                var cilfuncs = src.Members.Where(f => f.Cil.IsSome()).Select(f => f.Cil.Value).ToArray();
                if(cilfuncs.Length == 0)
                    return default;

                using var writer = new StreamWriter(CilPath(src.Id).FullPath,append);
                foreach(var f in cilfuncs)
                {
                    writer.Write(CilFormatter.Format(f));
                    if(GroupFormatConfig.EmitSectionDelimiter)
                        writer.WriteLine(GroupFormatConfig.SectionDelimiter);
                }                    
                return default;
            }
            catch(Exception e)
            {
                return e;                
            }
        }

        Option<AsmCaptureTokenGroup> WriteAsm(AsmFunctionGroup src, bool append)
        {
            try
            {
                var tokens = new AsmCaptureToken[src.Members.Length];
                using var writer = new StreamWriter(AsmPath(src.Id).FullPath, append);            
                for(var i=0; i < src.Members.Length;i++)
                {
                    var f = src.Members[i];
                    var uri = OpUri.Asm(HostPath, src.Id, f.Id);
                    writer.Write(GroupFormatter.FormatDetail(f));
                    tokens[i] = AsmCaptureToken.Define(uri, f.AddressRange, f.TermCode);
                }
                return tokens.ToGroup(OpUri.Asm(HostPath, src.Id));
            }
            catch(Exception e)
            {
                term.error(e);
                return none<AsmCaptureTokenGroup>();
            }
        }
 
        void OnEmitting(AsmFunctionGroup src)
        {
            
        }

        void OnEmitted(AsmCaptureTokenGroup emitted)
            => term.print(Emitted(emitted));            

        void OnInOutMismatch(OpIdentity id, int incount, int outcount)
            => term.print(EmissionMismatch(id,incount,outcount));
            
        FilePath HexPath(OpIdentity id)
            => EmissionPaths.OpArchivePath(ArchiveFileKind.Hex, Origin, HostName, id).CreateParentIfMissing();

        FilePath AsmPath(OpIdentity id)
            => EmissionPaths.OpArchivePath(ArchiveFileKind.Asm, Origin, HostName, id).CreateParentIfMissing();

        FilePath CilPath(OpIdentity id)
            => EmissionPaths.OpArchivePath(ArchiveFileKind.Cil, Origin, HostName, id).CreateParentIfMissing();
    }
}