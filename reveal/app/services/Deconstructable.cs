//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.IO;

    public abstract class Deconstructable<T> : IDeconstructable<T>
        where T : Deconstructable<T>
    {        
        protected Deconstructable(string SourcePath)
        {
            this.SourcePath = FilePath.Define(SourcePath);
        }

        public FilePath SourcePath {get;}
        
        public void Emit()
        {
            var dstfolder = SourcePath.FolderPath;
            var asmfile =  SourcePath.WithExtension(FileExtension.Define("asm"));
            var cilfile = SourcePath.WithExtension(FileExtension.Define("il"));
            var host = typeof(T);
            var clridx = ClrMetadataIndex.Create(host.Assembly);
            var context = AsmServices.Context(clridx, DataResourceIndex.Empty, AsmFormatConfig.Default.WithSectionDelimiter());
            using var capture = AsmProcessServices.Capture(context);
            var deconstructed = capture.CaptureFunctions(host);            
            AsmServices.AsmFunctionEmitter(context).EmitAsm(deconstructed, asmfile).OnSome(e => throw e);
            AsmServices.AsmFunctionEmitter(context).EmitCil(deconstructed, cilfile).OnSome(e => throw e);
        }
    }
}