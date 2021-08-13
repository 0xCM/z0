//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    unsafe partial struct Buffers
    {
        /// <summary>
        /// Creates an array of tokens that identify a sequence of buffers
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="size">The number of bytes covered by each buffer</param>
        /// <param name="count">The length of the buffer sequence</param>
        [Op]
        public static BufferToken[] tokenize(IntPtr @base, uint size, uint count)
        {
            var tokens = new BufferToken[count];
            for(var i=0; i<count; i++)
                seek(tokens,i) = (IntPtr.Add(@base, (int)size*i), size);
            return tokens;
        }

        /// <summary>
        /// Creates an array of tokens that identify a sequence of buffers
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="size">The number of bytes covered by each buffer</param>
        /// <param name="count">The length of the buffer sequence</param>
        [Op]
        public static BufferToken[] tokenize(MemoryAddress @base, uint size, uint count)
        {
            var tokens = new BufferToken[count];
            for(var i=0u; i<count; i++)
                seek(tokens,i) = (@base + (size*i), size);
            return tokens;
        }

        /// <summary>
        /// Creates an array of tokens that identify a sequence of buffers
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="size">The number of bytes covered by each represented buffer</param>
        /// <param name="count">The length of the buffer sequence</param>
        public static NativeCellToken<F>[] tokenize<F>(IntPtr @base, uint size, uint count)
            where F : unmanaged, IDataCell
        {
            var tokens = new NativeCellToken<F>[count];
            for(var i=0; i<count; i++)
                tokens[i] = new NativeCellToken<F>(IntPtr.Add(@base, (int)size*i), size);
            return tokens;
        }
    }
}