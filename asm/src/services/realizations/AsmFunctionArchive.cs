//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    class AsmFunctionArchive : IAsmFunctionArchive
    {
        readonly FolderPath TargetFolder;
        
        readonly AsmArchiveConfig Config;

        public string Catalog {get;}

        public string Subject {get;}

        public static IAsmFunctionArchive Define(string catalog, string subject, AsmArchiveConfig? config = null)
            => new AsmFunctionArchive(catalog,subject, config ?? AsmArchiveConfig.Default);

        AsmFunctionArchive(string catalog, string subject, AsmArchiveConfig config)
        {
            this.Catalog = catalog;
            this.Subject = subject;
            this.TargetFolder = Paths.AsmDataDir(RelativeLocation.Define(catalog, subject));
            this.Config = config;
        }

        public AsmDescriptor Save(AsmFunction src)
        {
            HexPath(src.Id).WriteText(src.Code.Format());
            DetailPath(src.Id).WriteText(src.FormatDetail());
            src.Cil.OnSome(cil => CilPath(src.Id).WriteText(cil.Format()));
            return AsmDescriptor.Define(AsmUri.Define(Catalog, Subject, src.Id), src.Location);            
        }

        public IEnumerable<AsmDescriptor> Save(IEnumerable<AsmFunction> src)
        {
            foreach(var f in src)
                yield return Save(f);
        }   
            
        public void Clear()
        {
            TargetFolder.DeleteFiles();
        }

        FilePath HexPath(Moniker m)
        {
            if(Config.SingleFile)
                return Paths.AsmDataDir(FolderName.Define(Catalog)) + FileName.Define(Subject, Paths.HexExt);
            else
                return Paths.AsmDataDir(RelativeLocation.Define(Catalog, Subject)) + Paths.AsmHexFile(m);
        }

        FilePath DetailPath(Moniker m)
        {
            if(Config.SingleFile)
                return Paths.AsmDataDir(FolderName.Define(Catalog)) + FileName.Define(Subject, Paths.AsmExt);
            else
                return Paths.AsmDataDir(RelativeLocation.Define(Catalog, Subject)) + Paths.AsmDetailFile(m);
        }

        FilePath CilPath(Moniker m)
        {
            if(Config.SingleFile)
                return Paths.AsmDataDir(FolderName.Define(Catalog)) + FileName.Define(Subject, Paths.CilExt);
            else
                return Paths.AsmDataDir(RelativeLocation.Define(Catalog, Subject)) + Paths.CilFile(m);
        }
    }
}