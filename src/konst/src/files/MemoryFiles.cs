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

        public ReadOnlySpan<byte> Read(MemoryAddress src, ByteSize size)
            => read(src, size);

        public ReadOnlySpan<T> Read<T>(in MemoryFile file, MemoryAddress src, uint count)
            where T : struct
                => read<T>(file, src, count);

        public ref readonly T Read<T>(MemoryAddress src)
            where T : struct
                => ref read<T>(src);

        public MemoryFileInfo Describe(in MemoryFile src)
            => describe(src);

        public MemoryFile Open(FS.FilePath src)
            => open(src);

        public MappedFiles Map(FS.FolderPath src)
            =>map(src);

        [MethodImpl(Inline), Op]
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
            var fi = src.Path.Info;
            dst.BaseAddress = src.BaseAddress;
            dst.Size = src.Size;
            dst.EndAddress = dst.BaseAddress + dst.Size;
            dst.Path = src.Path;
            dst.CreateTS = fi.CreationTime;
            dst.UpdateTS = fi.LastWriteTime;
            dst.Attributes = fi.Attributes;
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<byte> read(MemoryAddress src, ByteSize size)
            => cover<byte>(src, size);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<byte> edit(MemoryAddress src, ByteSize size)
            => cover<byte>(src, size);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(MemoryAddress src)
            where T : struct
                => ref first(cover<T>(src, 1));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe ReadOnlySpan<T> read<T>(in MemoryFile file, MemoryAddress src, uint count)
            where T : struct
                => cover<T>(src + file.BaseAddress, count);
    }
}