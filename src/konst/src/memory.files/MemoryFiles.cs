//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct MemoryFiles
    {
        public static MemoryFile open(FS.FilePath path)
            => new MemoryFile(path.Name);

        [Op]
        public static MemoryFileInfo describe(in MemoryFile src)
        {
            var dst = new MemoryFileInfo();
            dst.BaseAddress = src.BaseAddress;
            var fi = src.Path.Info;
            var desc =new FS.FsEntryDetail();
            desc.Path = FS.path(src.Path.Name);
            desc.Size = (ByteSize)fi.Length;
            desc.CreateTS = fi.CreationTime;
            desc.UpdateTS = fi.LastWriteTime;
            desc.Attributes = fi.Attributes;
            dst.Description = desc;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Span<byte> Read(MemoryAddress src, uint size)
            => z.cover(src, size);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T Read<T>(MemoryAddress src)
            where T : struct
                => ref first(cover<T>(src, 1));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ReadOnlySpan<T> Read<T>(in MemoryFile file, MemoryAddress src, uint count)
            where T : struct
                => cover<T>(src + file.Base, count);
    }
}