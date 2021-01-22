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
        public static FilePath CreateParentIfMissing(this FilePath src)
            => FileOps.CreateParent(src);

        public static void Append(this FS.FilePath dst, params string[] src)
        {
            using var writer = new StreamWriter(dst.EnsureParentExists().Name, true);
            foreach(var line in src)
                writer.WriteLine(line);
        }

        public static void Append(this FS.FilePath dst, string src)
            => File.AppendAllText(dst.Name, src);

        public static void AppendLine(this FilePath dst, string src)
        {
            File.AppendAllLines(dst.Name, z.array(src));
        }

    }
}