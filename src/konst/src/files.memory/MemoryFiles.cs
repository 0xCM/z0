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
    public readonly partial struct MemoryFiles : IMemoryFileReader
    {
        const NumericKind Closure = UnsignedInts;

        public IWfShell Wf {get;}

        [MethodImpl(Inline)]
        MemoryFiles(IWfShell wf)
            => Wf = wf;

        public ReadOnlySpan<byte> Read(MemoryAddress src, ByteSize size)
            => read(src, size);

        public ReadOnlySpan<T> View<T>(in MemoryFile file, MemoryAddress src, uint count)
            where T : struct
                => read<T>(file, src, count);

        public ref readonly T View<T>(MemoryAddress src)
            where T : struct
                => ref read<T>(src);

        public MemoryFileInfo Describe(in MemoryFile src)
            => describe(src);

        public MemoryFile Map(FS.FilePath src)
            => map(src);

        public MappedFiles Map(FS.FolderPath src)
            => map(src);

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
        public static unsafe ReadOnlySpan<T> read<T>(in MemoryFile file, MemoryAddress start, uint count)
            where T : struct
                => cover<T>(start + file.BaseAddress, count);
    }
}