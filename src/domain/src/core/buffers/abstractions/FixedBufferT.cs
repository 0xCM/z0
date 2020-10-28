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
    using api = FixedBuffers;

    public abstract class FixedBuffer<T> : IFixedBuffer<T>
    {
        public abstract uint CellCount {get;}

        /// <summary>
        /// Specifies the address of the buffer, not its content
        /// </summary>
        public MemoryAddress BufferAddress {get; protected set;}

        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => api.covered(this);
        }

        [MethodImpl(Inline)]
        public ref T Cell(uint index, out T value)
        {
            api.cell(this, index, out value);
            return ref value;
        }

        [MethodImpl(Inline)]
        public void Enumerate(ClosedInterval<uint> range, Action<T> receiver)
            => api.enumerate(this, range, receiver);

        [MethodImpl(Inline)]
        public void Enumerate(Action<T> receiver)
            => api.enumerate(this, receiver);

        protected abstract void Populate(Span<T> dst);
    }
}