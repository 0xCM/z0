//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.IO.MemoryMappedFiles;

    using static Konst;

    using api = MemoryFiles;

    [ApiHost]
    public unsafe readonly struct MemoryFile : IDisposable
    {
        internal readonly byte* Base;

        internal readonly FilePath Path;

        readonly MemoryMappedFile File;

        readonly MemoryMappedViewAccessor View;

        public readonly ulong Size;

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Base;
        }

        [MethodImpl(Inline), Op]
        public Span<byte> Read(MemoryAddress src, uint size)
            => z.cover(src, size);

        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public ref readonly T Read<T>(MemoryAddress src)
        //     where T : struct
        //         => ref first(cover<T>(src, 1));

        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public ReadOnlySpan<T> Read<T>(MemoryAddress src, uint count)
        //     where T : struct
        //         => api.Read<T>(this, src, count);

        internal MemoryFile(string path)
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
            => api.describe(this);

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