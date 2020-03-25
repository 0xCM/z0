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
    using System.Threading.Tasks;

    using static Custom;

    public static class FileSystemExtensions
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
            => File.ReadAllText(src.FullPath);

        /// <summary>
        /// Reads the line-partitioned content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string[] ReadLines(this FilePath src)
            => File.ReadAllLines(src.FullPath);

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
            => File.ReadAllBytes(src.FullPath);

        /// <summary>
        /// Creates a writer initialized with the source file; caller-disposal required
        /// </summary>
        /// <param name="dst">The file path</param>
        public static StreamWriter Writer(this FilePath dst, bool append = false)
            => new StreamWriter(dst.CreateParentIfMissing().FullPath, append);

        public static StreamWriter Writer(this FilePath dst, FileWriteMode mode)
            => new StreamWriter(dst.CreateParentIfMissing().FullPath, mode == FileWriteMode.Append);

        /// <summary>
        /// Determines whether a file exists
        /// </summary>
        /// <param name="src">The path for which existence will be tested</param>
        public static bool Exists(this FilePath src)
            => File.Exists(src.FullPath);

        /// <summary>
        /// Determines whether a directory exists
        /// </summary>
        /// <param name="src">The path for which existence will be tested</param>
        public static bool Exists(this FolderPath src)
            => Directory.Exists(src.Name);

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
        /// Deletes all files in a specified directory, but neither does it recurse nor delete folders
        /// </summary>
        /// <param name="dst">The target path</param>
        public static FolderPath Clear(this FolderPath dst)
        {   
            if(Directory.Exists(dst.Name)) 
                Streams.iter(Directory.EnumerateFiles(dst.Name), File.Delete);
            return dst;
        }

        public static void Append(this FilePath dst, string src)
            => File.AppendAllText(dst.CreateParentIfMissing().FullPath, src);

        public static void AppendLine(this FilePath dst, string src)
            => dst.Append(new string[]{src});

        public static void Append(this FilePath dst, IEnumerable<string> src)
        {
            var count = 0;
            using var writer = new StreamWriter(dst.CreateParentIfMissing().FullPath,true);            
            foreach(var line in src)
            {
                writer.WriteLine(line);
                count++;
            }
        }

        public static Task AppendAsync(this FilePath dst, string src)
            => File.AppendAllTextAsync(dst.CreateParentIfMissing().FullPath, src);

        public static Task AppendAsync(this FilePath dst, IEnumerable<string> src)
            => File.AppendAllLinesAsync(dst.CreateParentIfMissing().FullPath, src);

        public static IEnumerable<FilePath> WithExtension(this IEnumerable<FilePath> src, FileExtension ext)
            => src.Where(path => path.Extension == ext);

        public static IEnumerable<FilePath> WithExtensions(this IEnumerable<FilePath> src, params FileExtension[] extensions)
            => src.Where(path => extensions.Any(e => e == path.Extension));

        public static FilePath CreateParentIfMissing(this FilePath src)
        {
            src.FolderPath.CreateIfMissing();
            return src;
        }
    }
}