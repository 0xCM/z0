//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Strings
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    /// <summary>
    /// Defines a string over S-symbols allocated over a native buffer
    /// </summary>
    public unsafe struct StringBuffer<S> : IDisposable
        where S : unmanaged
    {
        readonly NativeBuffer<S> Buffer;

        public StringBuffer(uint count)
        {
            Buffer = memory.native<S>(count);
            Buffer.Clear();
        }

        public StringBuffer(int count)
        {
            Buffer = memory.native<S>((uint)count);
            Buffer.Clear();
        }

        public void Dispose()
        {
            Buffer.Dispose();
        }

        /// <summary>
        /// The maximum number of symbols in the string
        /// </summary>
        public uint Length
        {
            [MethodImpl(Inline)]
            get => Buffer.Count;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length*size<S>();
        }

        [MethodImpl(Inline)]
        public MemoryAddress Address(ulong index)
            => Buffer.Address + index*size<S>();

        [MethodImpl(Inline)]
        public MemoryAddress Address(long index)
            => Address((ulong)index);

        [MethodImpl(Inline)]
        public ref S Symbol(ulong index)
            => ref seek(Buffer.Edit,index);

        [MethodImpl(Inline)]
        public ref S Symbol(long index)
            => ref seek(Buffer.Edit,index);

        [MethodImpl(Inline)]
        public Word<S> Substring(ulong index, ulong length)
            => strings.word(this, index, length);

        [MethodImpl(Inline)]
        public Word<S> Substring(long index, long length)
            => strings.word(this, index, length);

        public ref S this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Symbol(index);
        }

        public ref S this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Symbol(index);
        }

        public Word<S> this[long offset, long length]
        {
            [MethodImpl(Inline)]
            get => strings.word(this, offset, length);
        }

        public Word<S> this[ulong offset, ulong length]
        {
            [MethodImpl(Inline)]
            get => strings.word(this, offset, length);
        }

        [MethodImpl(Inline)]
        public bool Store(ReadOnlySpan<S> src, uint offset)
            => strings.store(src, offset, this);
    }
}