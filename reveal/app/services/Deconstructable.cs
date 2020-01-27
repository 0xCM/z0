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
            this.TargetFolder = FolderPath.Define(Path.GetDirectoryName(SourcePath));
            this.AsmFileName = FileName.Define(Path.ChangeExtension(Path.GetFileName(SourcePath),"asm"));
            this.CilFileName = FileName.Define(Path.ChangeExtension(Path.GetFileName(SourcePath),"il"));
        }

        public FolderPath TargetFolder {get;}

        public FileName AsmFileName {get;}

        public FileName CilFileName {get;}

        public void Emit()
        {
            var host = typeof(T);
            var clridx = ClrMetadataIndex.Create(host.Assembly);
            var context = AsmServices.Context(clridx, DataResourceIndex.Empty, AsmFormatConfig.Default.WithSectionDelimiter());
            using var capture = AsmProcessServices.Capture(context);
            var deconstructed = capture.CaptureFunctions(host);
            var emitter = AsmServices.CodeEmitter(context,TargetFolder);
            emitter.EmitAsm(deconstructed, AsmFileName);
            emitter.EmitCil(deconstructed, CilFileName);
        }

    }
}