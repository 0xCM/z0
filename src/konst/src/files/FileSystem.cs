//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Konst;

    public readonly partial struct FileOps
    {        
        public static string SearchPattern(params FileExtension[] extensions)
            => text.join(";*.", extensions.Select(e => e.Name));
    
        /// <summary>
        /// Creates the containing folder if it does not exist
        /// </summary>
        /// <param name="src">The file path</param>
        /// <remarks>The operation is idempotent</remarks>
        public static FilePath CreateParent(FilePath src)
        {
            create(src.FolderPath);
            return src;
        }

        public static string CreateParent(string path)
        {
            var dir = Path.GetDirectoryName(path);
            if(!Directory.Exists(dir)) 
                Directory.CreateDirectory(dir);
            return path;
        }

        /// <summary>
        /// Creates the specified folder if it does not exist; if it already exists, the file system is unmodified.
        /// </summary>
        /// <param name="dst">The source path</param>
        /// <remarks>The operation is idempotent</remarks>
        public static FolderPath create(FolderPath dst)
        {   
            if(!Directory.Exists(dst.Name)) 
                Directory.CreateDirectory(dst.Name);
            return dst;
        }

        /// <summary>
        /// Deletes the file if it exists
        /// </summary>
        /// <param name="src">The path to the file</param>
        public static void delete(FilePath src)
        {
            if(src.Exists)
                File.Delete(src.FullPath);
        }
    }
}