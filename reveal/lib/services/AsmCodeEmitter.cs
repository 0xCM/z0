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

        public void EmitAsm(IEnumerable<MethodDisassembly> disassembly)        
        {
            using var writer = Writer();
            var asm = disassembly.DistillAsm().ToArray();
            Emit(asm, writer);
        }

        public void EmitAsm(IEnumerable<AsmFuncInfo> disassembly)        
        {
            using var writer = Writer();
            Emit(disassembly.ToArray(), writer);
        }

        StreamWriter Writer()   
        {
            TargetRoot.CreateIfMissing();
            return new StreamWriter(TargetPath.FullPath, false);
        }

        void Emit(AsmFuncInfo[] src, StreamWriter dst)
        {
            dst.WriteLine($"; {now().ToLexicalString()}");
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