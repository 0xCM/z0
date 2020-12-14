//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;

    using static Konst;

    partial struct FS
    {
        public static void clear(FS.FolderPath src, bool recurse = false)
        {
            if(Directory.Exists(src.Name))
            {
                foreach(var f in src.Files(recurse))
                    f.Delete();
            }
        }

        public static List<FS.FilePath> clear(FS.FolderPath src, List<FS.FilePath> dst, bool recurse = false)
        {
            if(Directory.Exists(src.Name))
            {
                foreach(var f in src.Files(recurse))
                    if(f.Delete())
                        dst.Add(f);
            }
            return dst;
        }

        /// <summary>
        /// Deletes the file if it exists
        /// </summary>
        /// <param name="src">The path to the file</param>
        public static Outcome<FilePath> delete(FilePath src)
        {
            if(src.Exists)
            {
                File.Delete(src.Name);
                return src;
            }
            else
                return default;
        }

        /// <summary>
        /// Deletes the file if it exists
        /// </summary>
        /// <param name="src">The path to the file</param>
        public static Outcome<FilePath> delete(FilePath src, Action<Exception> error)
        {
            try
            {
                if(!src.Exists)
                    return default;

                File.Delete(src.Name);
                return src;

            }
            catch(Exception e)
            {
                error(e);
                return e;
            }
        }
    }
}