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

    partial class XTend
    {
        /// <summary>
        /// Reads the full content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string ReadText(this FilePath src)
            => FileSystem.text(src);

        /// <summary>
        /// Reads the line-partitioned content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string[] ReadLines(this FilePath src)
            => FileSystem.lines(src);

        /// <summary>
        /// Reads the full content of a file into a byte array
        /// </summary>
        /// <param name="src">The file path</param>
        public static byte[] ReadBytes(this FilePath src)
            => FileSystem.bytes(src);

        /// <summary>
        /// Deletes the file if it exists
        /// </summary>
        /// <param name="src">The path to the file</param>
        public static void Delete(this FilePath src)
            => FileSystem.delete(src);

        /// <summary>
        /// Creates a folder if it doesn't exist
        /// </summary>
        /// <param name="dst">The target path</param>
        public static FolderPath CreateIfMissing(this FolderPath dst)
            => FileSystem.reify(dst);

        /// <summary>
        /// Deletes all files in a specified directory, but neither does it recurse nor delete folders
        /// </summary>
        /// <param name="dst">The target path</param>
        public static FolderPath Clear(this FolderPath dst)
            => FileSystem.clear(dst);

        public static FilePath CreateParentIfMissing(this FilePath src)
            => FileSystem.reifyParent(src);

        public static void Append(this FilePath dst, string src)
            => FileSystem.append(dst,src);

        public static void AppendLine(this FilePath dst, string src)
            => FileSystem.appendLine(dst,src);

        public static void Append(this FilePath dst, IEnumerable<string> src)
            => FileSystem.append(dst,src);

        public static Task AppendAsync(this FilePath dst, string src)
            => File.AppendAllTextAsync(dst.CreateParentIfMissing().FullPath, src);

        public static Task AppendAsync(this FilePath dst, IEnumerable<string> src)
            => File.AppendAllLinesAsync(dst.CreateParentIfMissing().FullPath, src); 
    }
}