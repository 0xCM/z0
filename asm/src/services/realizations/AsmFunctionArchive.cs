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
        public FolderPath Root {get;}
        
        readonly AsmFormatConfig GroupFormatConfig;

        readonly IAsmFunctionFormatter DefaultFormatter;

        readonly IAsmFunctionFormatter GroupFormatter;

        readonly ICilFormatter CilFormatter;

        public IAsmContext Context {get;}

        public string Catalog {get;}

        public string Subject {get;}

        public static IAsmFunctionArchive Create(IAsmContext context, string catalog, string subject)
            => new AsmFunctionArchive(context, catalog,subject);

        AsmFunctionArchive(IAsmContext context, string catalog, string subject)
        {
            this.Context = context;
            this.Catalog = catalog;
            this.Subject = subject;
            this.Root = Paths.AsmDataDir(RelativeLocation.Define(catalog, subject));
            this.DefaultFormatter = context.AsmFormatter();
            this.GroupFormatConfig = AsmFormatConfig.Default.WithSectionDelimiter().WithoutFunctionTimestamp().WithoutFunctionOrigin();
            this.GroupFormatter = context.WithFormat(GroupFormatConfig).AsmFormatter();
            this.CilFormatter = context.CilFormatter();
        }

        public AsmEmissionToken Save(AsmFunction src)
        {
            HexPath(src.Id).WriteText(src.Code.Format());
            AsmPath(src.Id).WriteText(DefaultFormatter.FormatDetail(src));
            src.Cil.OnSome(cil => CilPath(src.Id).WriteText(CilFormatter.Format(cil)));
            return AsmEmissionToken.Define(OpUri.Asm(Catalog, Subject, src.Id), src.Location);
        }


        public Option<AsmEmissionGroup> Save(AsmFunctionGroup src, bool append)
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
            Root.DeleteFiles();
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

        Option<AsmEmissionGroup> WriteAsm(AsmFunctionGroup src, bool append)
        {
            try
            {
                var tokens = new AsmEmissionToken[src.Members.Length];
                using var writer = new StreamWriter(AsmPath(src.Id).FullPath, append);            
                for(var i=0; i < src.Members.Length;i++)
                {
                    var f = src.Members[i];
                    var uri = OpUri.Asm(Catalog, Subject, src.Id, f.Id);
                    writer.Write(GroupFormatter.FormatDetail(f));
                    tokens[i] = AsmEmissionToken.Define(uri, f.Location);
                }
                return tokens.ToGroup(src.Id);
            }
            catch(Exception e)
            {
                errout(e);
                return none<AsmEmissionGroup>();
            }
        }

        FilePath HexPath(OpIdentity m)
            => Paths.AsmDataDir(RelativeLocation.Define(Catalog, Subject)).CreateIfMissing() + Paths.AsmHexFile(m);

        FilePath AsmPath(OpIdentity m)
            => Paths.AsmDataDir(RelativeLocation.Define(Catalog, Subject)).CreateIfMissing() + Paths.AsmDetailFile(m);

        FilePath CilPath(OpIdentity m)
            => Paths.AsmDataDir(RelativeLocation.Define(Catalog, Subject)).CreateIfMissing() + Paths.CilFile(m);
 
        void OnEmitting(AsmFunctionGroup src)
        {
            print(Emitting(src));
        }

        void OnEmitted(AsmEmissionGroup emitted)
        {
            print(Emitted(emitted));            
        }

        void OnInOutMismatch(OpIdentity id, int incount, int outcount)
        {
            print(EmissionMismatch(id,incount,outcount));
        }
 
    }
}