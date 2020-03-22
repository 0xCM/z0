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


    using static AsmServiceMessages;

    using static Root;

    class AsmFunctionArchive : IAsmFunctionArchive
    {        
        public static AppMsg Emitted(AsmEmissionTokens<OpUri> src)
            => AppMsg.Info($"Emitted {src.Source}");

        public FolderPath RootFolder {get;}
        
        public IAsmContext Context {get;}

        public PartId Origin {get;}

        public string HostName {get;}

        public ApiHostUri HostPath {get;}

        readonly AsmFormatConfig GroupFormatConfig;

        readonly IAsmFormatter DefaultFormatter;

        readonly IAsmFormatter GroupFormatter;

        readonly ICilFunctionFormatter CilFormatter;

        AsmEmissionPaths EmissionPaths
            => Context.EmissionPaths();

        [MethodImpl(Inline)]
        public static IAsmFunctionArchive Create(IAsmContext context, PartId catalog, string host)
            => new AsmFunctionArchive(context, catalog,host);

        [MethodImpl(Inline)]
        public static IAsmFunctionArchive Create(IAsmContext context, ApiHostUri host, bool imm)
            => new AsmFunctionArchive(context, host, imm);

        AsmFunctionArchive(IAsmContext context, ApiHostUri host, bool imm)
        {
            this.Context = context;
            this.Origin = host.Owner;
            this.HostName = $"{host.Name}-imm";
            this.HostPath = host;
            this.RootFolder = context.EmissionPaths().DataSubDir(RelativeLocation.Define(host.Owner.Format(), $"{host.Name}-imm"));
            this.DefaultFormatter = context.AsmFormatter();
            this.GroupFormatConfig = AsmFormatConfig.New.WithSectionDelimiter().WithoutFunctionTimestamp().WithoutFunctionOrigin();
            this.GroupFormatter = context.WithFormat(GroupFormatConfig).AsmFormatter();
            this.CilFormatter = context.CilFormatter();
        }
        
        AsmFunctionArchive(IAsmContext context, PartId catalog, string hostname)
        {
            this.Context = context;
            this.Origin = catalog;
            this.HostName = hostname;
            this.HostPath = ApiHostUri.Define(catalog, hostname);
            this.RootFolder = context.EmissionPaths().DataSubDir(RelativeLocation.Define(catalog.Format(), hostname));
            this.DefaultFormatter = context.AsmFormatter();
            this.GroupFormatConfig = AsmFormatConfig.New.WithSectionDelimiter().WithoutFunctionTimestamp().WithoutFunctionOrigin();
            this.GroupFormatter = context.WithFormat(GroupFormatConfig).AsmFormatter();
            this.CilFormatter = context.CilFormatter();
        }

        public Option<AsmEmissionTokens<OpUri>> Save(AsmFunctionGroup src, bool append)
        {            
            OnEmitting(src);
            WriteHex(src, append).OnSome(e => term.error(e));
            //WriteCil(src, append).OnSome(e => term.error(e));            
            var emissions = WriteAsm(src,append);
            var incount = src.Members.Length;
            var outcount = emissions.MapValueOrDefault(t => t.Content.Length);
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

        // Option<Exception> WriteCil(AsmFunctionGroup src, bool append)
        // {
        //     try
        //     {                
        //         var cilfuncs = src.Members.Where(f => f.Cil.IsSome()).Select(f => f.Cil.Value).ToArray();
        //         if(cilfuncs.Length == 0)
        //             return default;

        //         using var writer = new StreamWriter(CilPath(src.Id).FullPath,append);
        //         foreach(var f in cilfuncs)
        //         {
        //             writer.Write(CilFormatter.Format(f));
        //             if(GroupFormatConfig.EmitSectionDelimiter)
        //                 writer.WriteLine(GroupFormatConfig.SectionDelimiter);
        //         }                    
        //         return default;
        //     }
        //     catch(Exception e)
        //     {
        //         return e;                
        //     }
        // }

        Option<AsmEmissionTokens<OpUri>> WriteAsm(AsmFunctionGroup src, bool append)
        {
            try
            {
                var tokens = new AsmEmissionToken[src.Members.Length];
                using var writer = new StreamWriter(AsmPath(src.Id).FullPath, append);            
                for(var i=0; i < src.Members.Length;i++)
                {
                    var f = src.Members[i];
                    var uri = OpUri.asm(HostPath, src.Id, f.Id);
                    writer.Write(GroupFormatter.FormatFunction(f));
                    tokens[i] = AsmEmissionToken.Define(uri, f.AddressRange, f.TermCode);
                }
                return AsmEmissionTokens.From(OpUri.asm(HostPath, src.Id),tokens);
            }
            catch(Exception e)
            {
                term.error(e);
                return none<AsmEmissionTokens<OpUri>>();
            }
        }
 
        void OnEmitting(AsmFunctionGroup src)
        {
            
        }

        void OnEmitted(AsmEmissionTokens<OpUri> emitted)
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