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

    using Z0.AsmSpecs;

    using static AsmServiceMessages;

    using static zfunc;

    class AsmFunctionArchive : IAsmFunctionArchive
    {        
        public FolderPath RootFolder {get;}
        
        readonly AsmFormatConfig GroupFormatConfig;

        readonly IAsmFunctionFormatter DefaultFormatter;

        readonly IAsmFunctionFormatter GroupFormatter;

        readonly ICilFunctionFormatter CilFormatter;

        public IAsmContext Context {get;}

        public AssemblyId Origin {get;}

        public string ApiHost {get;}

        public static IAsmFunctionArchive Create(IAsmContext context, AssemblyId catalog, string host)
            => new AsmFunctionArchive(context, catalog,host);

        AsmFunctionArchive(IAsmContext context, AssemblyId catalog, string host)
        {
            this.Context = context;
            this.Origin = catalog;
            this.ApiHost = host;
            this.RootFolder = Paths.AsmDataDir(RelativeLocation.Define(catalog.Format(), host));
            this.DefaultFormatter = context.AsmFormatter();
            this.GroupFormatConfig = AsmFormatConfig.Default.WithSectionDelimiter().WithoutFunctionTimestamp().WithoutFunctionOrigin();
            this.GroupFormatter = context.WithFormat(GroupFormatConfig).AsmFormatter();
            this.CilFormatter = context.CilFormatter();
        }

        public Option<CaptureTokenGroup> Save(AsmFunctionGroup src, bool append)
        {            
            OnEmitting(src);
            WriteHex(src, append).OnSome(e => errout(e));
            WriteCil(src, append).OnSome(e => errout(e));            
            var emissions = WriteAsm(src,append);
            var incount = src.Members.Length;
            var outcount = emissions.MapValueOrDefault(t => t.Tokens.Length);
            if(incount != outcount)
               OnInOutMismatch(src.Id, incount, outcount);                
            
            return emissions.OnSome(OnEmitted);
        }

        public IAsmFunctionArchive Clear()
        {
            RootFolder.DeleteFiles();
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

        Option<CaptureTokenGroup> WriteAsm(AsmFunctionGroup src, bool append)
        {
            try
            {
                var tokens = new CaptureToken[src.Members.Length];
                using var writer = new StreamWriter(AsmPath(src.Id).FullPath, append);            
                for(var i=0; i < src.Members.Length;i++)
                {
                    var f = src.Members[i];
                    var uri = OpUri.AsmOp(Origin, ApiHost, src.Id, f.Id);
                    writer.Write(GroupFormatter.FormatDetail(f));
                    tokens[i] = CaptureToken.Define(f.CaptureInfo, uri);
                }
                return tokens.ToGroup(OpUri.AsmGroup(Origin, ApiHost, src.Id));
            }
            catch(Exception e)
            {
                errout(e);
                return none<CaptureTokenGroup>();
            }
        }
 
        void OnEmitting(AsmFunctionGroup src)
        {
            
        }

        void OnEmitted(CaptureTokenGroup emitted)
        {
            print(Emitted(emitted));            
        }

        void OnInOutMismatch(OpIdentity id, int incount, int outcount)
        {
            print(EmissionMismatch(id,incount,outcount));
        }

        FilePath HexPath(OpIdentity id)
            => ArchiveFileKind.Hex.ArchivePath(Origin, ApiHost, id).CreateParentIfMissing();

        FilePath AsmPath(OpIdentity id)
            => ArchiveFileKind.Asm.ArchivePath(Origin, ApiHost, id).CreateParentIfMissing();

        FilePath CilPath(OpIdentity id)
            => ArchiveFileKind.Cil.ArchivePath(Origin, ApiHost, id).CreateParentIfMissing();
    }
}