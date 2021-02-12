//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

    [ApiHost]
    public readonly partial struct Archives
    {
        public static IRuntimeArchive runtime(IWfShell wf)
            => RuntimeArchive.create(wf.Controller.ImageDir);

        [MethodImpl(Inline)]
        public static IApiHexReader hexreader<H>(H rep = default)
            where H : struct, IArchiveReader
        {
            if(typeof(H) == typeof(ApiExtractReader))
                return new ApiExtractReader();
            else
                throw no<H>();
        }

        [MethodImpl(Inline)]
        public static ApiExtractWriter hexwriter<H>(FS.FilePath dst, H rep = default)
            where H : struct, IArchiveWriter<H>
        {
            if(typeof(H) == typeof(ApiExtractWriter))
                return new ApiExtractWriter(dst);
            else
                throw no<H>();
        }

        /// <summary>
        /// Creates an archive over the output of a build
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static IBuildArchive build(IWfShell wf,  FS.FolderPath root)
            => new BuildArchive(wf, root);

        [MethodImpl(Inline), Op]
        public static IBuildArchive build(IWfShell wf)
            => build(wf, FS.path(wf.Controller.Component.Location).FolderPath);

        /// <summary>
        /// Creates an archive over both managed and unmanaged modules
        /// </summary>
        /// <param name="root">The archive root</param>
        [MethodImpl(Inline), Op]
        public static IModuleArchive modules(FS.FolderPath root)
            => new ModuleArchive(root);

        [Op]
        public static FS.Files match(FS.FolderPath root, params FS.FileExt[] ext)
        {
            var files = create(root, ext).ArchiveFiles().Array();
            Array.Sort(files);
            return files;
        }

        [Op]
        public static FS.Files match(FS.FolderPath root, uint max, params FS.FileExt[] ext)
        {
            var files = create(root, ext).ArchiveFiles().Take(max).Array();
            Array.Sort(files);
            return files;
        }

        [Op]
        public static ListedFiles match(FileArchive src, string pattern, bool recurse)
            => FS.list(Directory.EnumerateFiles(src.Root.Name, pattern, option(recurse)).Array().Select(x => FS.path(pattern)));

        [MethodImpl(Inline), Op]
        public static IFileArchive create(FS.FolderPath root)
            => new FileArchive(root);

        [MethodImpl(Inline), Op]
        public static IFileArchive create(FS.FolderPath root, string filter)
            => new FilteredArchive(root, filter);

        [MethodImpl(Inline), Op]
        public static IFileArchive create(FS.FolderPath root, params FS.FileExt[] ext)
            => new FilteredArchive(root, ext);

        [MethodImpl(Inline)]
        internal static SearchOption option(bool recurse)
            => recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

        [Op]
        public static Outcome<FileEmission> emit(FS.FilePath[] src, bool uri, FS.FilePath dst)
        {
            var counter  = 0;
            try
            {
                var count = src.Length;
                using var writer = dst.Writer();
                foreach(var file in src)
                {
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