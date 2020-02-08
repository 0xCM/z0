//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.IO;

    using static zfunc;

    public static class IOX
    {
        /// <summary>
        /// Creates a reader initialized with the source file; caller-disposal required
        /// </summary>
        /// <param name="src">The file path</param>
        public static StreamReader Reader(this FilePath src)
            => new StreamReader(src.FullPath);

        /// <summary>
        /// Reads the full content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string ReadText(this FilePath src)
            => File.ReadAllText(src.ToString());

        /// <summary>
        /// Reads the line-partitioned content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static IEnumerable<string> ReadLines(this FilePath src)
            => File.ReadAllLines(src.ToString());

        /// <summary>
        /// Reads the full content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static Option<string> TryReadText(this FilePath src)
        {
            try
            {
                if(src.Exists())
                    return File.ReadAllText(src.ToString());
            }
            catch(Exception)
            {
                return default;
            }
            
            return default;

        }

        /// <summary>
        /// Reads the full content of a file into a byte array
        /// </summary>
        /// <param name="src">The file path</param>
        public static byte[] ReadBytes(this FilePath src)
            => File.ReadAllBytes(src.ToString());

        /// <summary>
        /// Creates a writer initialized with the source file; caller-disposal required
        /// </summary>
        /// <param name="dst">The file path</param>
        public static StreamWriter Writer(this FilePath dst)
        {
            return new StreamWriter(dst.CreateFolderIfMissing().FullPath, false);
        }

        /// <summary>
        /// Creates or overwrites a file with supplied text
        /// </summary>
        /// <param name="dst">The target path</param>
        /// <param name="src">The source text</param>
        public static void WriteText(this FilePath dst, string src)
        {
            if(!string.IsNullOrWhiteSpace(src))
            {
                
                File.WriteAllText(dst.CreateFolderIfMissing().FullPath, src);
            }
        }

        /// <summary>
        /// Determines whether a file exists
        /// </summary>
        /// <param name="src">The file path for which existence is in question</param>
        public static bool Exists(this FilePath src)
            => File.Exists(src.FullPath);

        /// <summary>
        /// Deletes the file if it exists
        /// </summary>
        /// <param name="src">The path to the file</param>
        public static void Delete(this FilePath src)
        {
            if(File.Exists(src.FullPath))
                File.Delete(src.FullPath);
        }

        /// <summary>
        /// Creates a folder if it doesn't exist
        /// </summary>
        /// <param name="dst">The target path</param>
        public static FolderPath CreateIfMissing(this FolderPath dst)
        {   if(!Directory.Exists(dst.Name)) 
                Directory.CreateDirectory(dst.Name);
            return dst;
        }

        /// <summary>
        /// Deletes all files in a specified directory
        /// </summary>
        /// <param name="dst">The target path</param>
        public static void DeleteFiles(this FolderPath dst)
        {   
            if(Directory.Exists(dst.Name)) 
                iter(Directory.EnumerateFiles(dst.Name), File.Delete);
        }

        public static int Overwrite(this FilePath dst, params string[] lines)
        {         
            var count = 0;
            using var writer = new StreamWriter(dst.CreateFolderIfMissing().FullPath,false);            
            foreach(var line in lines)
            {
                writer.WriteLine(line);
                count++;
            }
            return count;
        }

        public static int Append(this FilePath dst, params string[] src)
            => dst.Append((IEnumerable<string>)src);
            
        public static int Append(this FilePath dst, IEnumerable<string> src)
        {
            var count = 0;
            using var writer = new StreamWriter(dst.CreateFolderIfMissing().FullPath,true);            
            foreach(var line in src)
            {
                writer.WriteLine(line);
                count++;
            }
            return count;
        }

        public static IEnumerable<FilePath> WithExtension(this IEnumerable<FilePath> src, FileExtension ext)
            => src.Where(path => path.Extension == ext);

        public static IEnumerable<FilePath> WithExtensions(this IEnumerable<FilePath> src, params FileExtension[] extensions)
            => src.Where(path => extensions.Any(e => e == path.Extension));

        public static FilePath CreateFolderIfMissing(this FilePath src)
        {
            src.FolderPath.CreateIfMissing();
            return src;
        }
    }
}