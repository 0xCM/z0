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

    using Z0.Asm;

    using static zfunc;

    readonly struct AsmProcessEmitter : IAsmProcessEmitter
    {
        readonly IAsmContext Context;

        public static IAsmProcessEmitter Create(IAsmContext context)
            => new AsmProcessEmitter(context);

        AsmProcessEmitter(IAsmContext context)
        {
            Context = context;
        }
            
        public void EmitFunctions(Type host)
        {
            var outdir = Context.EmissionPaths().AsmDumpDir.CreateIfMissing();
            var name = host.DisplayName();
            using var capture = AsmProcessServices.Capture(Context);
            var functions = capture.CaptureFunctions(host);
            var outpath = outdir + FileName.Define(name, FileExtensions.Asm);
            var emitter = Context.AsmEmitter();
            emitter.EmitAsm(functions, outpath).OnSome(e => throw e);
            EmitCil(functions, name);                
        }

        void EmitCil(IEnumerable<AsmFunction> functions, string name)
        {
            using var writer = EmissionWriter(name, "il", false);
            writer.WriteLine($"// {now().ToLexicalString()}");
            var formatter = Context.CilFormatter();
            foreach(var f in functions)
                writer.WriteLine(f.Cil.MapValueOrElse(cil => formatter.Format(cil), () => string.Empty));
        }

        StreamWriter EmissionWriter(string name, string extension, bool timestamped)
        {
            var dstFileName = FileName.Define(name) + FileExtension.Define(extension);
            if(timestamped)
                dstFileName = FileName.Timestamped(dstFileName);        
            var dstPath = Context.EmissionPaths().AsmDataDir(FolderName.Define(".dumps")).CreateIfMissing() + dstFileName;
            return new StreamWriter(dstPath.ToString(),false);
        }        
    }
}