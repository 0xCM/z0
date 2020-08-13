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

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Base;
        }

        [MethodImpl(Inline)]
        public static MemoryFile open(string path)
            => new MemoryFile(path);
        
        [MethodImpl(Inline)]
        public static MemoryFile resbundle()
            => open(AppPaths.Default.ResBytes.Name);
        
        [MethodImpl(Inline), Op]
        public Span<byte> Read(MemoryAddress src, uint size)
            => z.cover(src + Base, size);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly T Read<T>(MemoryAddress src)
            where T : struct
                => ref first(cover<T>(src + Base, 1));

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
        }

        public FileInfo FileInfo
            => Path.Info;
        
        public void Dispose()
        {
            View?.Dispose();
            File?.Dispose();
        }
    }
}