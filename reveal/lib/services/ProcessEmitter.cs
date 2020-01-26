//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.IO;
    using System.Collections.Generic;

    using Z0.AsmSpecs;

    using static zfunc;

    readonly struct AsmProcessEmitter : IAsmProcessEmitter
    {
        public static IAsmProcessEmitter Create()
            => default(AsmProcessEmitter);
            
        public void EmitFunctions(Type host)
        {
            var outdir = Paths.AsmDumpDir.CreateIfMissing();         
            var name = host.DisplayName();
            using var capture = AsmProcessServices.Capture(host.Module);
            var functions = capture.CaptureFunctions(host);
            var outpath = outdir + FileName.Define(name, Paths.AsmExt);
            var emitter = AsmServices.CodeEmitter(outdir, AsmFormatConfig.Default.WithSectionDelimiter());
            emitter.EmitAsm(functions, FileName.Define(name, Paths.AsmExt));
            EmitCil(functions, name);                
        }

        void EmitCil(IEnumerable<AsmFunction> functions, string name)
        {
            using var writer = EmissionWriter(name, "il", false);
            writer.WriteLine($"// {now().ToLexicalString()}");
            foreach(var f in functions)
                writer.WriteLine(f.Cil.MapValueOrElse(cil => cil.Format(), () => string.Empty));
        }

        StreamWriter EmissionWriter(string name, string extension, bool timestamped)
        {
            var dstFileName = FileName.Define(name) + FileExtension.Define(extension);
            if(timestamped)
                dstFileName = FileName.Timestamped(dstFileName);        
            var dstPath = Paths.AsmDataDir(FolderName.Define(".dumps")).CreateIfMissing() + dstFileName;
            return new StreamWriter(dstPath.ToString(),false);
        }        
    }
}