//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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

    public static class CodeEmitter
    {

        /// <summary>
        /// Writes asm code to a file
        /// </summary>
        /// <param name="src">The assembly source</param>
        /// <param name="dst">The target path</param>
        /// <param name="append">Wheter to append content to an existing file or overwrite an existing file</param>
        public static void EmitAsm(this AsmFuncInfo src, FilePath dst, bool append = false)
        {
            using var writer = EmissionWriter(dst, append);
            if(append)
                writer.WriteLine(AsmSeparator);
            
            writer.WriteLine($"; {now().ToLexicalString()}");
            writer.Write(src.Format());
        }

        public static void EmitAsm(this MethodDisassembly disassembly, FilePath dst, bool append = false)        
            => disassembly.DistillAsmFunction().EmitAsm(dst,append);

        /// <summary>
        /// Writes each disasesembled method to file derived from the name of the method
        /// </summary>
        /// <param name="disassembly">Disassembled methods to emit</param>
        /// <param name="dst">The target folder</param>
        /// <param name="append">Whether existing files should be appended or replaced</param>
        public static void EmitAsmFiles(this IEnumerable<MethodDisassembly> disassembly, FolderPath dst, bool append = false)
        {
            foreach(var asm in disassembly.DistillAsmFunctions())
            {
                var filename = FileName.Define(asm.FunctionName, "asm");
                asm.EmitAsm(dst + filename,append);
            }
        }

        public static void EmitAsm(this IEnumerable<MethodDisassembly> disassembly, FilePath dst)        
        {
            using var writer = EmissionWriter(dst);
            var asm = disassembly.DistillAsmFunctions().ToArray();
            asm.Emit(writer);
        }

        public static void EmitCil(this IEnumerable<MethodDisassembly> disassembly, FilePath dst)
        {
            using var writer = EmissionWriter(dst);
            writer.WriteLine($"// {now().ToLexicalString()}");
            disassembly.EmitCil(writer);
        }

        public static void EmitAsm(this IEnumerable<MethodDisassembly> disassembly, string name, bool timestamped = false)
        {
            using var writer = EmissionWriter(name, "asm", timestamped);
            var asm = disassembly.Select(d => d.DistillAsmFunction()).ToArray();
            asm.Emit(writer);
        }

        public static void EmitCil(this IEnumerable<MethodDisassembly> disassembly, string name, bool timestamped = false)
        {
            using var writer = EmissionWriter(name, "il", timestamped);
            writer.WriteLine($"// {now().ToLexicalString()}");
            foreach(var d in disassembly)
                writer.WriteLine(d.FormatCil());
        }
        
        public static void Emit(this IEnumerable<MethodDisassembly> disassembly, string name, bool asm = true, bool cil = false)
        {
            if(asm)
                disassembly.EmitAsm(name); 
            
            if(cil)
                disassembly.EmitCil(name); 
        }

        public static void Emit(this AsmFuncInfo[] src, FilePath dstfile)
        {
            using var dst = EmissionWriter(dstfile);
            src.Emit(dst);
        }

        public static void Emit(this AsmFuncInfo[] src, string name)
        {
            using var dst = EmissionWriter(name, "asm", false);
            src.Emit(dst);
        }        

        public static void EmitAsm(this IEnumerable<MethodInfo> methods, FilePath dst)
            => Deconstructor.Deconstruct(methods).EmitAsm(dst);
        
        public static void EmitCil(this IEnumerable<MethodInfo> methods, FilePath name)
            => Deconstructor.Deconstruct(methods).EmitCil(name);

        static readonly string AsmSeparator = new string('-', 160);

        static StreamWriter EmissionWriter(FilePath dst, bool append = false)   
        {
            dst.FolderPath.CreateIfMissing();
            return new StreamWriter(dst.FullPath, append);
        }

        static void Emit(this AsmFuncInfo[] src, StreamWriter dst)
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

        static void EmitCil(this IEnumerable<MethodDisassembly> disassembly, StreamWriter dst)
        {
            foreach(var d in disassembly)
                dst.WriteLine(d.FormatCil());
        }

        static StreamWriter EmissionWriter(string name, string extension, bool timestamped)
        {
            var dstFolder = FolderPath.Define(Settings.ProjectDir("reveal")) +  FolderName.Define(".dumps");
            var dstFileName = FileName.Define(name) + FileExtension.Define(extension);
            if(timestamped)
                dstFileName = FileName.Timestamped(dstFileName);
            var dstPath = dstFolder.CreateIfMissing() + dstFileName;
            return new StreamWriter(dstPath.ToString(),false);
        }        
    }
}