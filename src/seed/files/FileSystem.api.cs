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

    public static class FileSystem
    {
        /// <summary>
        /// Determines whether a file exists
        /// </summary>
        /// <param name="src">The path for which existence will be tested</param>
        public static bool extant(FilePath src)
            => File.Exists(src.FullPath);

        /// <summary>
        /// Determines whether a directory exists
        /// </summary>
        /// <param name="src">The path for which existence will be tested</param>
        public static bool extant(FolderPath src)
            => Directory.Exists(src.Name);

        public static FolderPath reify(FolderPath dst)
        {   
            if(!Directory.Exists(dst.Name)) 
                Directory.CreateDirectory(dst.Name);
            return dst;
        }

        /// <summary>
        /// Creates a reader initialized with the source file; caller-disposal required
        /// </summary>
        /// <param name="src">The file path</param>
        public static StreamReader reader(FilePath src)
            => new StreamReader(src.FullPath);

        public static FilePath reifyParent(FilePath src)
        {
            reify(src.FolderPath);
            return src;
        }

        /// <summary>
        /// Reads the full content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string text(FilePath src)
            => extant(src) ? File.ReadAllText(src.FullPath) : string.Empty;

        /// <summary>
        /// Reads the line-partitioned content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string[] lines(FilePath src)
            => extant(src) ? File.ReadAllLines(src.FullPath) : new string[]{};

        // public static FolderPath clear(FolderPath dst)
        // {   
        //     if(extant(dst)) 
        //     {
        //         foreach(var f in Directory.EnumerateFiles(dst.Name))
        //             File.Delete(f);
        //     }
        //     return dst;
        // }

        public static void append(FilePath dst, IEnumerable<string> src)
        {
            var count = 0;
            using var writer = new StreamWriter(reifyParent(dst).FullPath,true);            
            foreach(var line in src)
            {
                writer.WriteLine(line);
                count++;
            }
        }

        public static void append(FilePath dst, string src)
            => File.AppendAllText(reifyParent(dst).FullPath, src);

        public static void appendLine(FilePath dst, string src)
            => append(dst, new string[]{src});

        /// <summary>
        /// Deletes the file if it exists
        /// </summary>
        /// <param name="src">The path to the file</param>
        public static void delete(FilePath src)
        {
            if(extant(src))
                File.Delete(src.FullPath);
        }

        /// <summary>
        /// Creates a writer initialized with the source file; caller-disposal required
        /// </summary>
        /// <param name="dst">The file path</param>
        public static StreamWriter writer(FilePath dst, bool append = false)
            => new StreamWriter(reifyParent(dst).FullPath, append);

        public static StreamWriter writer(FilePath dst, FileWriteMode mode)
            => new StreamWriter(reifyParent(dst).FullPath, mode == FileWriteMode.Append);

        /// <summary>
        /// Reads the full content of a file into a byte array
        /// </summary>
        /// <param name="src">The file path</param>
        public static byte[] bytes(FilePath src)
            => extant(src) ? File.ReadAllBytes(src.FullPath) : new byte[]{};
    }
}