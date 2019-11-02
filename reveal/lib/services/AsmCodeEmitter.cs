//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;

    using static zfunc;

    public struct AsmCodeEmitter
    {
        public static AsmCodeEmitter Create(FilePath target)
            => new AsmCodeEmitter(target);

        public static FilePath OutPath(FolderPath dstFolder, string logicalName)            
            => dstFolder + (FileName.Define(logicalName) + FileExtension.Define("asm"));

        static readonly string AsmSeparator = new string('-', 160);

        public AsmCodeEmitter(FilePath TargetPath)
        {
            this.TargetRoot = TargetPath.FolderPath;
            this.TargetPath = TargetPath;
        }

        public readonly FolderPath TargetRoot {get;}

        public readonly FilePath TargetPath {get;}

        void EmitTimestamp(StreamWriter writer)
            => writer.WriteLine($"; {now().ToLexicalString()}"); 

        public void EmitAsm(IEnumerable<MethodDisassembly> disassembly, bool append = false)        
        {
            using var writer = Writer();

            var asm = disassembly.DistillAsm().ToArray();
            if(asm.Length != 0)
            {
                if(append)
                    EmitTimestamp(writer);

                Emit(asm, writer, !append);
            }
        }

        public void EmitAsm(IEnumerable<Type> types, FilePath dst)        
        {
            using var writer = Writer(false);
            EmitTimestamp(writer);                

            foreach(var t in types)
            {
                var asm = t.DistillAsm();
                if(asm.Length == 0)
                    continue;

                Emit(asm, writer, false);
            }            
        }

        public void EmitAsm(IEnumerable<AsmFuncInfo> disassembly, bool append)        
        {
            using var writer = Writer(append);

            var asm = disassembly.ToArray();
            if(asm.Length != 0)
            {            
                if(append)
                    EmitTimestamp(writer);
                
                Emit(asm, writer, !append);
            }
        }

        StreamWriter Writer(bool append = false)   
        {
            TargetRoot.CreateIfMissing();
            return new StreamWriter(TargetPath.FullPath, append);
        }

        void Emit(AsmFuncInfo[] src, StreamWriter dst, bool timestamp)
        {
            if(src.Length == 0)
                return;
            
            if(timestamp)
                EmitTimestamp(dst);

            for(var i=0; i< src.Length; i++)
            {   
                var spec = src[i];             
                dst.Write(spec.Format());
                if(i != i-1)
                    dst.WriteLine(AsmSeparator);
            }
        }

    }

}