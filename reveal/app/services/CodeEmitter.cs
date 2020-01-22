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
        public static void EmitAsm(this AsmFunction src, FilePath dst, bool append = false)
        {
            using var writer = EmissionWriter(dst, append);
            if(append)
                writer.WriteLine(AsmSeparator);
            
            writer.WriteLine($"; {now().ToLexicalString()}");
            writer.Write(src.FormatDetail());
        }

        public static void EmitAsm(this IEnumerable<AsmFunction> functions, FilePath dst)        
        {
            using var writer = EmissionWriter(dst);            
            writer.WriteLine($"; {now().ToLexicalString()}");
            var src = functions.ToArray();
            for(var i=0; i< src.Length; i++)
            {   
                var spec = src[i];             
                writer.Write(spec.FormatDetail());
                if(i != i-1)
                    writer.WriteLine(AsmSeparator);
            }
        }

        public static void EmitCil(this IEnumerable<AsmFunction> functions, string name)
        {
            using var writer = EmissionWriter(name, "il", false);
            writer.WriteLine($"// {now().ToLexicalString()}");
            foreach(var f in functions)
                writer.WriteLine(f.Cil.MapValueOrElse(cil => cil.Format(), () => string.Empty));
        }

        public static void EmitCil(this IEnumerable<AsmFunction> functions, FilePath dst)
        {
            using var writer = EmissionWriter(dst, false);
            writer.WriteLine($"// {now().ToLexicalString()}");
            foreach(var f in functions)
                writer.WriteLine(f.Cil.MapValueOrElse(cil => cil.Format(), () => string.Empty));
        }

        static readonly string AsmSeparator = new string('-', 160);

        static StreamWriter EmissionWriter(FilePath dst, bool append = false)   
        {
            dst.FolderPath.CreateIfMissing();
            return new StreamWriter(dst.FullPath, append);
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