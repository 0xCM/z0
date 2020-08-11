//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Reads the full content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string ReadText(this FilePath src)
            => FileOps.ReadText(src);

        /// <summary>
        /// Reads the line-partitioned content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string[] ReadLines(this FilePath src)
            => FileOps.ReadLines(src);

        /// <summary>
        /// Reads the full content of a file into a byte array
        /// </summary>
        /// <param name="src">The file path</param>
        public static byte[] ReadBytes(this FilePath src)
            => FileOps.ReadBytes(src);

        /// <summary>
        /// Deletes the file if it exists
        /// </summary>
        /// <param name="src">The path to the file</param>
        public static Option<FilePath> Delete(this FilePath src)
        {
            try
            {
                FileOps.delete(src);
                return src;
            }
            catch(Exception)
            {
                return z.none<FilePath>();
            }
        }

        public static FilePath CreateParentIfMissing(this FilePath src)
            => FileOps.CreateParent(src);

        public static void Append(this FilePath dst, params string[] src)
        {
            using var writer = new StreamWriter(reifyParent(dst).Name, true);            
            foreach(var line in src)
                writer.WriteLine(line);
        }

        public static void Ovewrite(this FilePath dst, params string[] src)
        {
            using var writer = new StreamWriter(reifyParent(dst).Name, false);            
            foreach(var line in src)
                writer.WriteLine(line);
        }

        public static void Append(this FilePath dst, string src)
            => File.AppendAllText(dst.Name, src);

        public static void AppendLine(this FilePath dst, string src)
        {
            File.AppendAllLines(dst.Name, z.array(src));
        }

        static FilePath reifyParent(FilePath src)
        {
            FileOps.create(src.FolderPath);
            return src;
        }
    }
}