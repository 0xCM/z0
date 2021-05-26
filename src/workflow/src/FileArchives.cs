//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct FileArchives
    {
        [Op]
        public static FS.Files match(FS.FolderPath root, uint max, params FS.FileExt[] ext)
        {
            var files = filtered(root, ext).Enumerate().Take(max).Array();
            Array.Sort(files);
            return files;
        }

        [Op]
        public static FS.Files match(FS.FolderPath root, params FS.FileExt[] ext)
        {
            var files = filtered(root, ext).Enumerate().Array();
            Array.Sort(files);
            return files;
        }

        [Op]
        public static ListedFiles list(FS.FilePath[] src)
            => new ListedFiles(src.Mapi((i,x) => new ListedFile(i,x)));

        [Op]
        public static ListedFiles list(FS.Files src)
            => new ListedFiles(src.Storage.Mapi((i,x) => new ListedFile((uint)i,x)));

        [Op]
        public static ListedFiles list(FS.FolderPath src, FS.FileExt ext, bool recurse = false)
            => src.Files(ext,recurse).Mapi((i,x) => new ListedFile((uint)i, x));

        [Op]
        public static ListedFiles list(FS.FolderPath src, bool recurse = false)
            => src.Files(recurse).Storage.Mapi((i,x) =>new ListedFile((uint)i, x));

        public static FS.Files list(FS.FolderPath src, FS.FileExt[] ext, uint limit = 0)
        {
            var list = limit != 0 ? match(src, limit, ext) : match(src, ext);
            return list;
        }

        [Op]
        public static ListedFiles list(FileArchive src, string pattern, bool recurse)
            => list(Directory.EnumerateFiles(src.Root.Name, pattern, option(recurse)).Array().Select(x => FS.path(pattern)));

        [MethodImpl(Inline), Op]
        public static IFileArchive create(FS.FolderPath root)
            => new FileArchive(root);

        [MethodImpl(Inline), Op]
        public static IFilteredArchive filtered(FS.FolderPath root, string filter)
            => new FilteredArchive(root, filter);

        [MethodImpl(Inline), Op]
        public static IFilteredArchive filtered(FS.FolderPath root, params FS.FileExt[] ext)
            => new FilteredArchive(root, ext);

        [MethodImpl(Inline)]
        internal static SearchOption option(bool recurse)
            => recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

        [Op]
        public static Outcome<FileEmission> emit(FS.Files src, bool uri, FS.FilePath dst)
        {
            var counter  = 0;
            try
            {
                var view = src.View;
                var count = view.Length;
                using var writer = dst.Writer();
                for(var i=0; i<count; i++)
                {
                    ref readonly var file = ref skip(view,i);
                    var line = uri ? file.ToUri().Format() : file.Format();
                    writer.WriteLine(line);
                    counter++;
                }

                return new FileEmission(dst, (int)counter);
            }
            catch(Exception e)
            {
                return e;
            }
        }
    }
}