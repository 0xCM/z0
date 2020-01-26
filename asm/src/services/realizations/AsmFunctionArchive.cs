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
        
        readonly AsmArchiveConfig ArchiveConfig;

        readonly AsmFormatConfig FormatConfig;

        readonly AsmFormatConfig GroupFormatConfig;

        readonly IAsmContentFormatter DefaultFormatter;

        readonly IAsmContentFormatter GroupFormatter;

        public string Catalog {get;}

        public string Subject {get;}

        public static IAsmFunctionArchive Create(string catalog, string subject)
            => new AsmFunctionArchive(catalog,subject, AsmArchiveConfig.Default);

        public static IAsmFunctionArchive Create(AssemblyId id, string subject)
            => Create(id.ToString().ToLower(),subject);

        public static IAsmFunctionArchive Create(AssemblyId id, Type subject)
            => Create(id.ToString().ToLower(),subject.Name.ToLower());

        static AsmFormatConfig ConfigureGroupFormatting()
            => AsmFormatConfig.Default.WithSectionDelimiter().WithoutFunctionTimestamp().WithoutFunctionOrigin();

        AsmFunctionArchive(string catalog, string subject, AsmArchiveConfig archiveConfig)
        {
            this.Catalog = catalog;
            this.Subject = subject;
            this.TargetFolder = Paths.AsmDataDir(RelativeLocation.Define(catalog, subject));
            this.ArchiveConfig = archiveConfig;
            this.FormatConfig = AsmFormatConfig.Default;
            this.DefaultFormatter = AsmServices.Formatter(FormatConfig);
            this.GroupFormatConfig = ConfigureGroupFormatting();
            this.GroupFormatter = AsmServices.Formatter(GroupFormatConfig);
        }

        public AsmEmissionToken Save(AsmFunction src)
        {
            HexPath(src.Id).WriteText(src.Code.Format());
            DetailPath(src.Id).WriteText(DefaultFormatter.FormatDetail(src));
            src.Cil.OnSome(cil => CilPath(src.Id).WriteText(cil.Format()));
            return AsmEmissionToken.Define(AsmUri.Define(Catalog, Subject, src.Id), src.Location);
        }

        public IEnumerable<AsmEmissionToken> Save(IEnumerable<AsmFunction> src)
            => src.Select(Save);
            
        void Write(CilFunction src, StreamWriter dst)
        {
            dst.Write(src.Format());
            if(GroupFormatConfig.EmitSectionDelimiter)
                dst.WriteLine(GroupFormatConfig.SectionDelimiter);
        }

        // string FormatHexLine(AsmFunction f, int idpad)
        //     => concat(f.Id.Text.PadRight(idpad), space(), f.Code.Encoded.FormatAsmHex());

        Option<Exception> WriteAsmHex(AsmFunctionGroup src)
        {
            try
            {
                var idpad = src.Members.Select(f => f.Id.Text.Length).Max() + 1;
                using var hexwriter = new StreamWriter(HexPath(src.Id).FullPath, false);
                foreach(var f in src.Members)
                    hexwriter.WriteLine(f.Code.Format(idpad));
                return default;
            }
            catch(Exception e)
            {
                return e;
            }
        }

        Option<Exception> WriteCilDetail(AsmFunctionGroup src)
        {
            if(!src.Members.Select(f => f.Cil.IsSome()).Any())
                return default;
            try
            {
                using var cilwriter = new StreamWriter(CilPath(src.Id).FullPath,false);
                foreach(var f in src.Members)
                    f.Cil.OnSome(cil => Write(cil,cilwriter));
                return default;
            }
            catch(Exception e)
            {
                return e;                
            }
        }

        public IEnumerable<AsmEmissionToken> Save(AsmFunctionGroup src)
        {
            
            using var asmwriter = new StreamWriter(DetailPath(src.Id).FullPath,false);
            WriteAsmHex(src).OnSome(e => errout(e));
            WriteCilDetail(src).OnSome(e => errout(e));
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
        {
            if(ArchiveConfig.SingleFile)
                return Paths.AsmDataDir(FolderName.Define(Catalog)).CreateIfMissing() + FileName.Define(Subject, Paths.HexExt);
            else
                return Paths.AsmDataDir(RelativeLocation.Define(Catalog, Subject)).CreateIfMissing() + Paths.AsmHexFile(m);
        }

        FilePath DetailPath(Moniker m)
        {
            if(ArchiveConfig.SingleFile)
                return Paths.AsmDataDir(FolderName.Define(Catalog)).CreateIfMissing() + FileName.Define(Subject, Paths.AsmExt);
            else
                return Paths.AsmDataDir(RelativeLocation.Define(Catalog, Subject)).CreateIfMissing() + Paths.AsmDetailFile(m);
        }

        FilePath CilPath(Moniker m)
        {
            if(ArchiveConfig.SingleFile)
                return Paths.AsmDataDir(FolderName.Define(Catalog)).CreateIfMissing() + FileName.Define(Subject, Paths.CilExt);
            else
                return Paths.AsmDataDir(RelativeLocation.Define(Catalog, Subject)).CreateIfMissing() + Paths.CilFile(m);
        }
    }
}