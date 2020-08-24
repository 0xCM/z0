//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;
    using System.IO.MemoryMappedFiles;

    using static Konst;
    using static z;

    [ApiHost]
    public unsafe readonly struct MemoryFile : IDisposable
    {
        readonly byte* Base;

        readonly FilePath Path;

        readonly MemoryMappedFile File;

        readonly MemoryMappedViewAccessor View;

        public readonly ulong Size;

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Base;
        }

        [MethodImpl(Inline)]
        public static MemoryFile open(string path)
            => new MemoryFile(path);

        [MethodImpl(Inline)]
        public static MemoryFile open(FS.FilePath path)
            => new MemoryFile(path.Name);

        public static MemoryFileInfo describe(in MemoryFile src)
        {
            var dst = new MemoryFileInfo();
            dst.BaseAddress = src.BaseAddress;
            var fi = src.Path.Info;
            var desc =new FS.EntryDetail();
            desc.Path = FS.path(src.Path.Name);
            desc.Size = (ByteSize)fi.Length;
            desc.CreateTS = fi.CreationTime;
            desc.UpdateTS = fi.LastWriteTime;
            desc.Attributes = fi.Attributes;
            dst.Description = desc;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public Span<byte> Read(MemoryAddress src, uint size)
            => z.cover(src, size);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly T Read<T>(MemoryAddress src)
            where T : struct
                => ref first(cover<T>(src, 1));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> Read<T>(MemoryAddress src, uint count)
            where T : struct
                => cover<T>(src + Base, count);

        public MemoryFile(string path)
        {
            Path = FilePath.Define(path);
            File = MemoryMappedFile.CreateFromFile(path, FileMode.Open, null, 0);
            View = File.CreateViewAccessor(0, 0);
            var @base = default(byte*);
            View.SafeMemoryMappedViewHandle.AcquirePointer(ref @base);
            Base = @base;
            Size = (ulong)Path.Info.Length;
        }

        public MemoryFileInfo Description
            => describe(this);

        public void Dispose()
        {
            View?.Dispose();
            File?.Dispose();
        }

        [MethodImpl(Inline)]
        public MemoryMappedViewStream Stream()
            => File.CreateViewStream();

        [MethodImpl(Inline)]
        public MemoryMappedViewStream Stream(MemoryAddress src, ByteSize size)
            => File.CreateViewStream(src, (int)size);
    }
}