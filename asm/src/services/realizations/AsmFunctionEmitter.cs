//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using AsmSpecs;

    using static zfunc;

    readonly struct AsmFunctionEmitter : IAsmFunctionEmitter
    {
        readonly IAsmContext Context;

        readonly FolderPath RootDir;

        public static AsmFunctionEmitter Create(IAsmContext context, FolderPath root)
            => new AsmFunctionEmitter(context,root);

        AsmFunctionEmitter(IAsmContext context, FolderPath dst)
        {
            this.Context = context;
            this.RootDir = dst;            
        }

        public void EmitCil(IEnumerable<AsmFunction> functions, FileName file)
        {
            var emittable = functions.Where(f => f.Cil.IsSome()).ToList();
            if(emittable.Count != 0)
            {
                using var writer = Writer(RootDir.CreateIfMissing() + file);
                EmitTimestamp(writer);                
                foreach(var f in functions)
                    f.Cil.OnSome(cil => writer.WriteLine(cil.Format()));
            }
        }

        public void EmitAsm(IEnumerable<AsmFunction> disassembly, FileName file)        
        {
            var src = disassembly.ToArray();
            if(src.Length == 0)
                return;

            var formatter = AsmServices.Formatter(Context);
            using var dst = Writer(RootDir.CreateIfMissing() + file);
                        
            for(var i=0; i< src.Length; i++)
                dst.Write(formatter.FormatDetail(src[i]));
        }

        void EmitTimestamp(StreamWriter writer)
            => writer.WriteLine($"; {now().ToLexicalString()}"); 
        
        StreamWriter Writer(FilePath file)   
            => new StreamWriter(file.FullPath, false);
    }
}