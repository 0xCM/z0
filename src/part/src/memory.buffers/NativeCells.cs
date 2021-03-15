//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiNames.CellBuffers, true)]
    public readonly struct NativeCells
    {
        /// <summary>
        /// Creates an array of tokens that identify a sequence of buffers
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="size">The number of bytes covered by each represented buffer</param>
        /// <param name="count">The length of the buffer sequence</param>
        [MethodImpl(Inline)]
        public static NativeCellToken<F>[] tokenize<F>(IntPtr @base, uint size, uint count)
            where F : unmanaged, IDataCell
        {
            var tokens = new NativeCellToken<F>[count];
            for(var i=0; i<count; i++)
                tokens[i] = new NativeCellToken<F>(IntPtr.Add(@base, (int)size*i), size);
            return tokens;
        }

        /// <summary>
        /// Allocates a buffer sequence over segments of width = 128 bits / 16 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [Op]
        public static NativeCells<Cell128> alloc(W128 width, byte count)
            => alloc<Cell128>(count);

        /// <summary>
        /// Allocates a buffer sequence over segments of width = 256 bits / 32 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [Op]
        public static NativeCells<Cell256> alloc(W256 width, byte count)
            => alloc<Cell256>(count);

        /// <summary>
        /// Allocates a buffer sequence over segments of width = 512 bits / 64 bytes
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [Op]
        public static NativeCells<Cell512> alloc(W512 width, byte count)
            => alloc<Cell512>(count);

        /// <summary>
        /// Allocates a buffer sequence over segments of fixed type
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [MethodImpl(Inline)]
        public static NativeCells<F> alloc<F>(byte count)
            where F : unmanaged, IDataCell
        {
            var bufferSize = (uint)default(F).Size;
            var totalSize = count*(bufferSize);
            var allocated = NativeBuffer.alloc(totalSize);
            return new NativeCells<F>(allocated, count, bufferSize, totalSize);
        }
    }
}