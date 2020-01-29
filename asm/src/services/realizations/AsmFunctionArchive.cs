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
        readonly FolderPath TargetFolder;
        
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
            this.TargetFolder = Paths.AsmDataDir(RelativeLocation.Define(catalog, subject));
            this.DefaultFormatter = context.AsmFormatter();
            this.GroupFormatConfig = AsmFormatConfig.Default.WithSectionDelimiter().WithoutFunctionTimestamp().WithoutFunctionOrigin();
            this.GroupFormatter = context.WithFormat(GroupFormatConfig).AsmFormatter();
            this.CilFormatter = context.CilFormatter();
        }

        public AsmEmissionToken Save(AsmFunction src)
        {
            HexPath(src.Id).WriteText(src.Code.Format());
            DetailPath(src.Id).WriteText(DefaultFormatter.FormatDetail(src));
            src.Cil.OnSome(cil => CilPath(src.Id).WriteText(CilFormatter.Format(cil)));
            return AsmEmissionToken.Define(AsmUri.Define(Catalog, Subject, src.Id), src.Location);
        }

        public IEnumerable<AsmEmissionToken> Save(IEnumerable<AsmFunction> src)
        {
            foreach(var f in src)
                yield return Save(f);
        }  
            
        void Write(CilFunction src, StreamWriter dst)
        {
            dst.Write(CilFormatter.Format(src));
            if(GroupFormatConfig.EmitSectionDelimiter)
                dst.WriteLine(GroupFormatConfig.SectionDelimiter);
        }

        Option<Exception> WriteAsmHex(AsmFunctionGroup src,bool append)
        {
            try
            {
                var idpad = src.Members.Select(f => f.Id.Text.Length).Max() + 1;
                using var hexwriter = new StreamWriter(HexPath(src.Id).FullPath, append);
                foreach(var f in src.Members)
                    hexwriter.WriteLine(f.Code.Format(idpad));
                return default;
            }
            catch(Exception e)
            {
                return e;
            }
        }

        Option<Exception> WriteCil(AsmFunctionGroup src, bool append)
        {
            var emittable = src.Members.Where(f => f.Cil.IsSome()).ToArray();
            if(emittable.Length == 0)
                return default;
            try
            {                
                using var cilwriter = new StreamWriter(CilPath(src.Id).FullPath,append);
                foreach(var f in src.Members)
                    f.Cil.OnSome(cil => Write(cil, cilwriter));
                return default;
            }
            catch(Exception e)
            {
                return e;                
            }
        }

        public IEnumerable<AsmEmissionToken> Save(AsmFunctionGroup src, bool append)
        {
            
            using var asmwriter = new StreamWriter(DetailPath(src.Id).FullPath,append);
            WriteAsmHex(src,append).OnSome(e => errout(e));
            WriteCil(src,append).OnSome(e => errout(e));
            foreach(var f in src.Members)
            {
                asmwriter.Write(GroupFormatter.FormatDetail(f));
                yield return AsmEmissionToken.Define(AsmUri.Define(Catalog, Subject, f.Id), f.Location);
            }
        }

        public IAsmFunctionArchive Clear()
        {
            TargetFolder.DeleteFiles();
            return this;
        }

        FilePath HexPath(Moniker m)
            => Paths.AsmDataDir(RelativeLocation.Define(Catalog, Subject)).CreateIfMissing() + Paths.AsmHexFile(m);

        FilePath DetailPath(Moniker m)
            => Paths.AsmDataDir(RelativeLocation.Define(Catalog, Subject)).CreateIfMissing() + Paths.AsmDetailFile(m);

        FilePath CilPath(Moniker m)
            => Paths.AsmDataDir(RelativeLocation.Define(Catalog, Subject)).CreateIfMissing() + Paths.CilFile(m);
    }
}