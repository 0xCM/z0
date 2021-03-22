//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Text;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct Archives
    {
        public static IRuntimeArchive runtime(IWfShell wf)
            => RuntimeArchive.create(wf.Controller.ImageDir);

        /// <summary>
        /// Creates an archive over both managed and unmanaged modules
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static IModuleArchive modules(FS.FolderPath root)
            => new ModuleArchive(root);

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

        [Op]
        public static string format(ListedFiles src)
        {
            var dst = Z0.text.build();
            format(src,dst);
            return dst.ToString();
        }

        [MethodImpl(Inline), Op]
        public static string format(ListedFile src)
            => Z0.text.format("{0,-10} | {1}", src.Index, src.Path);

        [Op]
        public static void format(ListedFiles src, StringBuilder dst)
        {
            var records = src.View;
            var count = records.Length;
            var header = Table.header<ListedFileField>();
            dst.AppendLine(header.HeaderText);
            for(var i=0u; i<count; i++)
            {
                ref readonly var record = ref src[i];
                dst.AppendLine(format(record));
            }
        }

        [MethodImpl(Inline), Op]
        public static void format(ListedFiles src, Span<string> dst)
        {
            var count = src.Count;
            var listed = src.View;
            ref readonly var file = ref src[0];
            ref var formatted = ref first(dst);

            for(var i=0u; i<count; i++)
                seek(formatted,i) = format(skip(file,i));
        }
    }
}