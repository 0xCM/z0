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

    /// <summary>
    /// Characterizes a buffer with an invariant address
    /// </summary>
    /// <typeparam name="T">The buffer cell type</typeparam>
    public interface IFixedBuffer<T>
    {
        /// <summary>
        /// The buffer's address which should remain unchanged throughout its lifetime
        /// </summary>
        /// <value></value>
        MemoryAddress BufferAddress {get;}

        /// <summary>
        /// The number of cells held in the buffer
        /// </summary>
        uint CellCount {get;}

        ref T Cell(uint index, out T value);

        void Enumerate(ClosedInterval<uint> range, Action<T>  receiver);

        void Enumerate(Action<T> receiver);
    }
}