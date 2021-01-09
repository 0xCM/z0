//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct MemoryFiles
    {
        [MethodImpl(Inline), Op]
        public static MemoryFile map(FS.FilePath path)
            => new MemoryFile(path);

        /// <summary>
        /// Creates a <see cref='MappedFiles'/> that covers the first level of a specified directory
        /// </summary>
        /// <param name="src">The source directory</param>
        [Op]
        public static MappedFiles map(FS.FolderPath src)
        {
            var files = src.EnumerateFiles(false).Array();
            if(files.Length != 0)
                return new MappedFiles(files.Select(map));
            else
                return MappedFiles.Empty;
        }
    }
}