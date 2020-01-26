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
            using var capture = AsmProcessServices.Capture(typeof(T).Module);
            var deconstructed = capture.CaptureFunctions(typeof(T));
            var emitter = AsmServices.CodeEmitter(TargetFolder, AsmFormatConfig.Default.WithSectionDelimiter());
            emitter.EmitAsm(deconstructed, AsmFileName);
            emitter.EmitCil(deconstructed, CilFileName);
        }

    }
}