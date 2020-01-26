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

    readonly struct AsmContentEmitter : IAsmContentEmitter
    {
        readonly FolderPath RootDir;

        readonly AsmFormatConfig Config;

        public static AsmContentEmitter Create(FolderPath root, AsmFormatConfig config)
            => new AsmContentEmitter(root,config);

        AsmContentEmitter(FolderPath dst, AsmFormatConfig config)
        {
            this.RootDir = dst;
            this.Config = config;
        }

        public void EmitCil(IEnumerable<AsmFunction> functions, FileName file)
        {
            using var writer = Writer(RootDir.CreateIfMissing() + file);
            EmitTimestamp(writer);                
            foreach(var f in functions)
                writer.WriteLine(f.Cil.MapValueOrElse(cil => cil.Format(), () => string.Empty));
        }

        public void EmitAsm(IEnumerable<AsmFunction> disassembly, FileName file)        
        {
            var src = disassembly.ToArray();
            if(src.Length == 0)
                return;

            var formatter = AsmServices.Formatter(Config);
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