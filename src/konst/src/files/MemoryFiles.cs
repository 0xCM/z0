//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;


    [ApiHost]
    public readonly struct MemoryFiles : IMemoryFiles
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static IMemoryFiles service(IWfShell wf)
            => new MemoryFiles(wf);

        public IWfShell Wf {get;}

        [MethodImpl(Inline)]
        MemoryFiles(IWfShell wf)
            => Wf = wf;

        public static MemoryFile open(FS.FilePath path)
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
                return new MappedFiles(files.Select(MemoryFiles.open));
            else
                return MappedFiles.Empty;
        }

        [Op]
        public static MemoryFileInfo describe(MemoryFile src)
        {
            var dst = new MemoryFileInfo();
            dst.BaseAddress = src.BaseAddress;
            var fi = src.Path.Info;
            var desc = new FS.FsEntryDetail();
            desc.Path = src.Path;
            desc.Size = (ByteSize)fi.Length;
            desc.CreateTS = fi.CreationTime;
            desc.UpdateTS = fi.LastWriteTime;
            desc.Attributes = fi.Attributes;
            dst.Description = desc;
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<byte> read(MemoryAddress src, ByteSize size)
            => memory.cover<byte>(src, size);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T read<T>(MemoryAddress src)
            where T : struct
                => ref first(cover<T>(src, 1));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe ReadOnlySpan<T> read<T>(in MemoryFile file, MemoryAddress src, uint count)
            where T : struct
                => cover<T>(src + file.BaseAddress, count);
    }
}