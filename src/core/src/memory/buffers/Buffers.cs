//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Windows;
    using System.IO;
    using System.Text;

    using static Windows.Kernel32;


    using static Root;
    using static core;

    /// <summary>
    /// Api for buffer manipulation
    /// </summary>
    [ApiHost]
    public unsafe struct Buffers
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Deallocates a native allocation
        /// </summary>
        /// <param name="handle">The allocation handle</param>
        [MethodImpl(Inline), Op]
        public static void release(IntPtr handle)
            => Marshal.FreeHGlobal(handle);

        /// <summary>
        /// Creates a caller-owed buffer sequence
        /// </summary>
        /// <param name="size">The size of each buffer</param>
        /// <param name="length">The sequence length</param>
        /// <param name="buffer">The allocation handle that defines ownership</param>
        [MethodImpl(Inline), Op]
        public static NativeBuffers alloc(uint size, byte length, out NativeBuffer buffer)
        {
            var buffers = NativeBuffers.alloc(size,length,false);
            buffer = buffers.Allocation;
            return buffers;
        }

        [Op]
        public static Allocation gcpin(byte[] buffer)
            => new Allocation(GCHandle.Alloc(buffer, GCHandleType.Pinned), (uint)buffer.Length);

        [Op, Closures(Closure)]
        public static Allocation<T> gcpin<T>(T[] buffer)
            where T : unmanaged
                => new Allocation<T>(GCHandle.Alloc(buffer, GCHandleType.Pinned), (uint)buffer.Length*size<T>());

        [Op]
        public static Allocation gcalloc(ByteSize size)
            => new Allocation(GCHandle.Alloc(new byte[size], GCHandleType.Pinned), size);

        [Op, Closures(Closure)]
        public static Allocation<T> gcalloc<T>(ulong count)
            where T : unmanaged
                => new Allocation<T>(GCHandle.Alloc(new T[count], GCHandleType.Pinned), (uint)count*size<T>());

        [Op, Closures(Closure)]
        public static Allocation<T> gcalloc<T>(long count)
            where T : unmanaged
                => gcalloc<T>((ulong)count);

        /// <summary>
        /// Allocates a caller-disposed stream over a string
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="encoding">The text encoding</param>
        [Op]
        public static MemoryStream stream(string src, Encoding encoding = null)
            => new MemoryStream((encoding ?? Encoding.UTF8).GetBytes(src ?? string.Empty));

        /// <summary>
        /// Allocates a native buffer
        /// </summary>
        /// <param name="size">The buffer length in bytes</param>
        [MethodImpl(Inline), Op]
        public static NativeBuffer native(uint size)
            => new NativeBuffer((liberate(Marshal.AllocHGlobal((int)size), (int)size), size));

        /// <summary>
        /// Allocates a buffer sequence over segments of fixed type
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline)]
        public static NativeCells<F> native<F>(byte count)
            where F : unmanaged, IDataCell
        {
            var bufferSize = (uint)default(F).Size;
            var totalSize = count*(bufferSize);
            var allocated = NativeBuffer.alloc(totalSize);
            return new NativeCells<F>(allocated, count, bufferSize, totalSize);
        }

        [Op]
        public static unsafe Span<byte> load(in BinaryCode src, BufferToken dst)
        {
            @check(src,dst);
            var source = span(src.Storage);
            var target = sys.clear(cover(dst.Address.Pointer<byte>(), dst.BufferSize));
            return sys.copy(source,target);
        }

        /// <summary>
        /// Creates an array of tokens that identify a sequence of buffers
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="size">The number of bytes covered by each buffer</param>
        /// <param name="count">The length of the buffer sequence</param>
        [MethodImpl(Inline), Op]
        public static BufferToken[] tokenize(IntPtr @base, uint size, uint count)
        {
            var tokens = new BufferToken[count];
            for(var i=0; i<count; i++)
                tokens[i] = (IntPtr.Add(@base, (int)size*i), size);
            return tokens;
        }

        /// <summary>
        /// Zero-fills a token-identified buffer and returns the cleared memory content
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Span<byte> clear(in NativeBuffers src, byte index)
            => sys.clear(edit(src.Token(index)));

        [MethodImpl(Inline), Op]
        public static void clear(BufferToken src)
            => edit(src).Clear();

        /// <summary>
        /// Covers a token-identified buffer with a bytespan
        /// </summary>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> edit(BufferToken src)
            => cover(src.Address.Pointer<byte>(), src.BufferSize);

        /// <summary>
        /// Covers a token-identified buffer with a span
        /// </summary>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Span<T> edit<T>(BufferToken src)
            where T : unmanaged
                => cover(src.Address.Pointer<byte>(), src.BufferSize).Recover<T>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public unsafe static T* valloc<T>(ulong size, MemAllocType type, PageProtection protection)
            where T : unmanaged
                => (T*)WinMem.VirtualAlloc(UIntPtr.Zero, (UIntPtr)size, type, protection);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public unsafe static bool vfree<T>(T* pSrc, ulong size, MemFreeType type)
            where T : unmanaged
                => VirtualFree((void*)pSrc, (UIntPtr)size, type);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe ref readonly SegRef<T> liberate<T>(in SegRef<T> src)
            where T : unmanaged
        {
            liberate(src.BaseAddress.Pointer<T>(), (int)src.Length);
            return ref src;
        }

        [MethodImpl(Inline), Op]
        public static unsafe bool liberate(ReadOnlySpan<byte> src, out byte* pDst)
        {
            var size = (ulong)src.Length;
            ref var cell = ref core.edit(core.first(src));
            var pCell = pointer(ref cell);
            if(liberate(pCell, size))
            {
                pDst = pCell;
                return true;
            }
            else
            {
                pDst = default;
                return false;
            }
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe bool liberate<T>(T* pSrc, ulong size)
            where T : unmanaged
        {
            IntPtr buffer = (IntPtr)(void*)pSrc;
            if (!WinMem.VirtualProtect(buffer, (UIntPtr)size, PageProtection.ExecuteReadWrite, out PageProtection _))
                return false;
            else
                return true;
        }

        /// <summary>
        /// Enables bytespan execution
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte* liberate(Span<byte> src)
            => liberate((byte*)pointer(ref first(src)), src.Length);

        /// <summary>
        /// This may not be the best idea to solve your problem
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte* liberate(ReadOnlySpan<byte> src)
            => liberate<byte>(ref core.edit(core.first(src)), src.Length);

        /// <summary>
        /// Enables execution over a reference-identified memory segment of specified length
        /// </summary>
        /// <param name="src">The buffer to let it be what it wants</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte* liberate(ref byte src, int length)
            => liberate((byte*)pointer(ref src), length);

        /// <summary>
        /// Enables execution over a specified memory range
        /// </summary>
        /// <param name="range">The range to liberate</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte* liberate(MemoryRange range)
            => liberate(range.Min.Pointer<byte>(), range.Size);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe T* liberate<T>(T* pSrc, int length)
            where T : unmanaged
        {
            IntPtr buffer = (IntPtr)(void*)pSrc;
            if (!VirtualProtectEx(CurrentProcess.ProcessHandle, buffer, (UIntPtr)length, PageProtection.ExecuteReadWrite, out PageProtection _))
                ThrowLiberationError(buffer, (ulong)length);
            return pSrc;
        }

        /// <summary>
        /// Enables en executable memory segment
        /// </summary>
        /// <param name="src">The leading cell reference</param>
        /// <param name="length">The length of the segment, in bytes</param>
        /// <typeparam name="T">The memory cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe T* liberate<T>(ref T src, int length)
            where T : unmanaged
        {
            var pSrc = Unsafe.AsPointer(ref src);
            IntPtr buffer = (IntPtr)pSrc;
            if (!VirtualProtectEx(CurrentProcess.ProcessHandle, buffer, (UIntPtr)length, PageProtection.ExecuteReadWrite, out PageProtection _))
                ThrowLiberationError(buffer, (ulong)length);
            return (T*)pSrc;
        }

        /// <summary>
        /// Enables an executable memory segment
        /// </summary>
        /// <param name="src">The leading cell pointer</param>
        /// <param name="length">The length of the segment, in bytes</param>
        [MethodImpl(Inline), Op]
        public static IntPtr liberate(IntPtr src, int length)
        {
            if (!VirtualProtectEx(CurrentProcess.ProcessHandle, src, (UIntPtr)(ulong)length, PageProtection.ExecuteReadWrite, out PageProtection _))
                ThrowLiberationError(src, (ulong)length);
            return src;
        }

        [MethodImpl(Inline), Op]
        public static MemoryAddress liberate(MemoryAddress src, ulong length)
             => VirtualProtectEx(CurrentProcess.ProcessHandle, src, (UIntPtr)(ulong)length, PageProtection.ExecuteReadWrite, out var _) ? src : MemoryAddress.Zero;

        internal static void ThrowLiberationError(IntPtr pCode, ulong Length)
        {
            var start = (ulong)pCode;
            var end = start + (ulong)Length;
            throw new Exception($"An attempt to liberate {Length} bytes of memory for execution failed");
        }

        [MethodImpl(Inline)]
        static void @check(in BinaryCode src, BufferToken dst)
        {
            var srcSize = src.Length;
            var dstSize = dst.BufferSize;
            if(src.Length > dst.BufferSize)
                sys.@throw("The buffer is too small");
        }
    }
}