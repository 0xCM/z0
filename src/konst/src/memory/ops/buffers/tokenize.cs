//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Buffers
    {
        /// <summary>
        /// Creates an array of tokens that identify a sequence of buffers
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="size">The number of bytes covered by each represented buffer</param>
        /// <param name="count">The length of the buffer sequence</param>
        [MethodImpl(Inline), Op]
        public static BufferToken<F>[] tokenize<F>(IntPtr @base, uint size, uint count)
            where F : unmanaged, IFixedCell
        {
            var tokens = new BufferToken<F>[count];
            for(var i=0; i<count; i++)
                tokens[i] = new BufferToken<F>(IntPtr.Add(@base, (int)size*i), size);
            return tokens;
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
    }
}