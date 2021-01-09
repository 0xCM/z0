//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    partial class XTend
    {
        /// <summary>
        /// Reads the line-partitioned content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        public static string[] ReadLines(this FilePath src)
            => FileOps.ReadLines(src);

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

        public static void Append(this FS.FilePath dst, params string[] src)
        {
            using var writer = new StreamWriter(reifyParent(dst).Name, true);
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