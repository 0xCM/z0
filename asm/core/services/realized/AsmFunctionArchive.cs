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
    using static AsmServiceMessages;    

    public class AsmFunctionArchive : IAsmFunctionArchive
    {        
        public static AppMsg Emitted(AsmEmissionTokens<OpUri> src)
            => AppMsg.Info($"Emitted {src.Source}");

        public FolderPath RootFolder {get;}
        
        public PartId SourcePart {get;}

        public string HostName {get;}

        public ApiHostUri HostPath {get;}
    
        readonly IAsmFormatter AsmFormatter;

        readonly ICilFunctionFormatter CilFormatter;

        readonly AsmEmissionPaths EmissionPaths;

        [MethodImpl(Inline)]
        public static IAsmFunctionArchive ImmArchive(IContext context, ApiHostUri host, IAsmFormatter formatter, FolderPath dst)
            => new AsmFunctionArchive(context, host, true, formatter, dst);

        AsmFunctionArchive(IContext context, ApiHostUri host, bool imm, IAsmFormatter formatter, FolderPath dst)
        {
            this.EmissionPaths = AsmEmissionPaths.Define(dst);
            this.SourcePart = host.Owner;
            this.HostName = $"{host.Name}-imm";
            this.HostPath = host;
            this.RootFolder = EmissionPaths.DataSubDir(RelativeLocation.Define(host.Owner.Format(), $"{host.Name}-imm"));
            this.AsmFormatter = formatter;
            this.CilFormatter = context.CilFormatter();
        }


        [MethodImpl(Inline)]
        public static IAsmFunctionArchive Create(IContext context, PartId catalog, string host, IAsmFormatter formatter)
            => new AsmFunctionArchive(context, catalog, host, formatter);

        [MethodImpl(Inline)]
        public static IAsmFunctionArchive Create(IContext context, ApiHostUri host, bool imm, IAsmFormatter formatter)
            => new AsmFunctionArchive(context, host, imm, formatter);

        AsmFunctionArchive(IContext context, ApiHostUri host, bool imm, IAsmFormatter formatter)
        {
            this.EmissionPaths = context.EmissionPaths();
            this.SourcePart = host.Owner;
            this.HostName = $"{host.Name}-imm";
            this.HostPath = host;
            this.RootFolder = context.EmissionPaths().DataSubDir(RelativeLocation.Define(host.Owner.Format(), $"{host.Name}-imm"));
            this.AsmFormatter = formatter;
            this.CilFormatter = context.CilFormatter();
        }
        
        AsmFunctionArchive(IContext context, PartId catalog, string hostname, IAsmFormatter formatter)
        {
            this.EmissionPaths = context.EmissionPaths();
            this.SourcePart = catalog;
            this.HostName = hostname;
            this.HostPath = ApiHostUri.Define(catalog, hostname);
            this.RootFolder = context.EmissionPaths().DataSubDir(RelativeLocation.Define(catalog.Format(), hostname));
            this.AsmFormatter = formatter;
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
                var idpad = src.Members.Select(f => f.OpId.Identifier.Length).Max() + 1;
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
                    var uri = OpUri.asm(HostPath, src.Id, f.OpId);
                    writer.Write(AsmFormatter.FormatFunction(f));
                    tokens[i] = AsmEmissionToken.Define(uri, f.AddressRange, f.TermCode);
                }
                return AsmEmissionTokens.From(OpUri.asm(HostPath, src.Id),tokens);
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<AsmEmissionTokens<OpUri>>();
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
            => EmissionPaths.OpArchivePath(ArchiveFileKind.Hex, SourcePart, HostName, id).CreateParentIfMissing();

        FilePath AsmPath(OpIdentity id)
            => EmissionPaths.OpArchivePath(ArchiveFileKind.Asm, SourcePart, HostName, id).CreateParentIfMissing();

        FilePath CilPath(OpIdentity id)
            => EmissionPaths.OpArchivePath(ArchiveFileKind.Cil, SourcePart, HostName, id).CreateParentIfMissing();
    }
}