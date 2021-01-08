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

    using static Part;

    using api = MemoryFiles;

    [ApiHost]
    public unsafe readonly struct MemoryFile : IDisposable, IComparable<MemoryFile>
    {
        readonly byte* Base;

        readonly MemoryMappedFile File;

        readonly MemoryMappedViewAccessor Accessor;

        public FS.FilePath Path {get;}

        public ByteSize Size {get;}

        internal MemoryFile(FS.FilePath path)
        {
            Path = path;
            File = MemoryMappedFile.CreateFromFile(path.Name, FileMode.Open, null, 0);
            Accessor = File.CreateViewAccessor(0, 0);
            var @base = default(byte*);
            Accessor.SafeMemoryMappedViewHandle.AcquirePointer(ref @base);
            Base = @base;
            Size = (ulong)Path.Info.Length;
        }

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Base;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline), Op]
            get => Base == null;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline), Op]
            get => Base != null;
        }

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> View(ulong offset, ByteSize size)
            => memory.cover<byte>(BaseAddress + offset, size);

        /// <summary>
        /// Presents file content as a readonly sequence of <see cref='byte'/> cells
        /// </summary>
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> View()
            => memory.cover<byte>(BaseAddress, Size);

        /// <summary>
        /// Presents file content as a readonly sequence of <typeparamref name='T'/> cells
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public ReadOnlySpan<T> View<T>()
            => memory.cover<T>(BaseAddress, Size/memory.size<T>());

        /// <summary>
        /// Presents file content segment as a readonly sequence of <typeparamref name='T'/> cells beginning
        /// at a <typeparamref name='T'/> measured offset and continuing to the end of the file
        /// </summary>
        /// <param name="tOffset">The number of cells to advance from the base address</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public ReadOnlySpan<T> View<T>(uint tOffset)
            => memory.slice(View<T>(), tOffset);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public ReadOnlySpan<T> View<T>(uint tOffset, uint tCount)
            => memory.slice(View<T>(), tOffset, tCount);

        public MemoryFileInfo Description
            => api.describe(this);

        public void Dispose()
        {
            Accessor?.Dispose();
            File?.Dispose();
        }

        [MethodImpl(Inline), Op]
        public MemoryMappedViewStream Stream()
            => File.CreateViewStream();

        [MethodImpl(Inline), Op]
        public MemoryMappedViewStream Stream(MemoryAddress src, ByteSize size)
            => File.CreateViewStream(src, (int)size);

        [MethodImpl(Inline)]
        public int CompareTo(MemoryFile src)
            => BaseAddress.CompareTo(src.BaseAddress);
    }
}