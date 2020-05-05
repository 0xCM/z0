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

    partial class XTend
    {
        /// <summary>
        /// Reads the full content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string ReadText(this FilePath src)
            => src.Exists ? File.ReadAllText(src.Name) : string.Empty;

        /// <summary>
        /// Reads the line-partitioned content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string[] ReadLines(this FilePath src)
            => src.Exists ? File.ReadAllLines(src.FullPath) : Control.array<string>();

        /// <summary>
        /// Reads the full content of a file into a byte array
        /// </summary>
        /// <param name="src">The file path</param>
        public static byte[] ReadBytes(this FilePath src)
            => src.Exists ? File.ReadAllBytes(src.FullPath) : Control.array<byte>();

        /// <summary>
        /// Deletes the file if it exists
        /// </summary>
        /// <param name="src">The path to the file</param>
        public static void Delete(this FilePath src)
        {
            if(src.Exists)
                File.Delete(src.FullPath);
        }

        public static FilePath CreateParentIfMissing(this FilePath src)
        {
            reify(src.FolderPath);
            return src;
        }

        public static void Append(this FilePath dst, IEnumerable<string> src)
        {
            var count = 0;
            using var writer = new StreamWriter(reifyParent(dst).Name, true);            
            foreach(var line in src)
            {
                writer.WriteLine(line);
                count++;
            }
        }

        public static void Append(this FilePath dst, string src)
            => File.AppendAllText(dst.Name, src);

        public static void AppendLine(this FilePath dst, string src)
            => dst.Append(new string[]{src});

        static FilePath reifyParent(FilePath src)
        {
            reify(src.FolderPath);
            return src;
        }

        static FolderPath reify(FolderPath dst)
        {   
            if(!Directory.Exists(dst.Name)) 
                Directory.CreateDirectory(dst.Name);
            return dst;
        }

    }
}