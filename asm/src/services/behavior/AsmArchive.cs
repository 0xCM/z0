//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class AsmArchive
    {
        public static AsmArchive Define(string subject)
            => new AsmArchive(subject);

        public static AsmArchive Define(IOperationCatalog catalog, string subject)
            => new AsmArchive(catalog.CatalogName,subject);

        public static AsmArchive Define(string catalog, string subject)
            => new AsmArchive(catalog,subject);

        AsmArchive(string catalog, string subject)
        {
            TargetFolder = LogPaths.The.AsmDataDir(RelativeLocation.Define(catalog, subject));
        }

        AsmArchive(string subject)
        {
            TargetFolder = LogPaths.The.AsmDataDir(FolderName.Define(subject));
        }
    
        FolderPath TargetFolder {get;}
        

        public void Save(AsmFuncInfo src)
        {
            Paths.AsmHexPath(TargetFolder, src.Id).WriteText(src.Code.Format());
            Paths.AsmDetailPath(TargetFolder, src.Id).WriteText(src.FormatDetail());
        }

        public void Save(IEnumerable<AsmFuncInfo> src)
        {
            iter(src,Save);
        }   

        public void Save(MethodDisassembly src)
        {
            Paths.AsmHexPath(TargetFolder, src.Id).WriteText(src.AsmCode.Format());
            Paths.AsmDetailPath(TargetFolder, src.Id).WriteText(AsmFunction.define(src).FormatDetail());
            src.CilFunction.OnSome(cil => Paths.CilPath(TargetFolder, src.Id).WriteText(cil.Format()));
        }

        public void Save(INativeMemberData src)
        {
            Paths.AsmHexPath(TargetFolder, src.Id).WriteText(src.Code.Format());
            Paths.AsmDetailPath(TargetFolder, src.Id).WriteText(AsmFunction.define(src).FormatDetail());
        }
            
        public void Clear()
        {
            TargetFolder.DeleteFiles();
        }

        public Option<AsmCode> ReadCode(Moniker m)
            =>  from text in Paths.AsmHexPath(TargetFolder, m).TryReadText()
                let code = AsmCode.Parse(text,m)
                select code;
    }
}