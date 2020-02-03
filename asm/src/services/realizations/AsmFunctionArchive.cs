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
            return AsmEmissionToken.Define(OpUri.Define(Catalog, Subject, src.Id), src.Location);
        }

        public IEnumerable<AsmEmissionToken> Save(AsmFunctionGroup src, bool append)
        {            
            WriteHex(src,append).OnSome(e => errout(e));
            WriteCil(src,append).OnSome(e => errout(e));
            return WriteAsm(src,append).ValueOrDefault(array<AsmEmissionToken>());
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

        Option<AsmEmissionToken[]> WriteAsm(AsmFunctionGroup src, bool append)
        {
            try
            {
                var tokens = new AsmEmissionToken[src.Members.Length];
                using var writer = new StreamWriter(AsmPath(src.Id).FullPath, append);            
                for(var i=0; i < src.Members.Length;i++)
                {
                    var f = src.Members[i];
                    writer.Write(GroupFormatter.FormatDetail(f));
                    var uri = OpUri.Define(Catalog, Subject, f.Id);
                    tokens[i] = AsmEmissionToken.Define(uri, f.Location);
                }
                return tokens;
            }
            catch(Exception e)
            {
                errout(e);
                return default;
            }
        }

        FilePath HexPath(OpIdentity m)
            => Paths.AsmDataDir(RelativeLocation.Define(Catalog, Subject)).CreateIfMissing() + Paths.AsmHexFile(m);

        FilePath AsmPath(OpIdentity m)
            => Paths.AsmDataDir(RelativeLocation.Define(Catalog, Subject)).CreateIfMissing() + Paths.AsmDetailFile(m);

        FilePath CilPath(OpIdentity m)
            => Paths.AsmDataDir(RelativeLocation.Define(Catalog, Subject)).CreateIfMissing() + Paths.CilFile(m);
    }
}