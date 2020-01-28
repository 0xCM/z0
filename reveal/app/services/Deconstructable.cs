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

    using static zfunc;

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
            var clridx = ClrMetadataIndex.Create(host.Assembly);
            var context = AsmContext.New(clridx, DataResourceIndex.Empty, AsmFormatConfig.Default.WithSectionDelimiter());
            using var capture = AsmProcessServices.Capture(context);
            var functions = capture.CaptureFunctions(host); 
            context.AsmEmitter().EmitAsm(functions, asmfile).OnSome(e => throw e);
            context.AsmEmitter().EmitCil(functions, cilfile).OnSome(e => throw e);

        }
    }
}