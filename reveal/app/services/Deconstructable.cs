//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using Z0.Asm;
    using System.Linq;
    using System.Collections.Generic;

    public abstract class Deconstructable<T> : IDeconstructable<T>
        where T : Deconstructable<T>
    {        
        protected Deconstructable(string SourcePath)
        {
            if(string.IsNullOrWhiteSpace(SourcePath))
                throw new ArgumentException("The source path is unspecified");

            this.SourcePath = FilePath.Define(SourcePath);
        }

        public FilePath SourcePath {get;}
        
        public void Emit()
        {
            var filename = SourcePath.FileName;
            var asmfile =  SourcePath.FolderPath + filename.WithExtension(FileExtensions.Asm);
            var cilfile = SourcePath.FolderPath + filename.WithExtension(FileExtensions.Il);
            var host = typeof(T);
            var clridx = host.Assembly.CreateClrIndex();
            var context = AsmContext.New(clridx, DataResourceIndex.Empty, AsmFormatConfig.New.WithSectionDelimiter());
            using var capture = AsmProcessServices.Capture(context);
            var functions = capture.CaptureFunctions(host); 
            using var asmwriter = context.AsmWriter(asmfile);
            asmwriter.Write(functions);            
            context.CilWriter(cilfile).Write(functions.Where(f => f.Cil.IsSome()).Select(x => x.Cil.Require()).ToArray());        
        }
    }
}