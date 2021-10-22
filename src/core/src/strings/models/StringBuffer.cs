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
    public unsafe struct StringBuffer : IDisposable
    {
        readonly NativeBuffer<char> Buffer;

        public StringBuffer(uint count)
        {
            Buffer = memory.native<char>(count);
            Buffer.Clear();
        }

        public StringBuffer(int count)
        {
            Buffer = memory.native<char>((uint)count);
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
            get => Length*size<char>();
        }

        [MethodImpl(Inline)]
        public MemoryAddress Address(ulong index)
            => Buffer.Address + index*2;

        [MethodImpl(Inline)]
        public MemoryAddress Address(long index)
            => Address((ulong)index);

        [MethodImpl(Inline)]
        public ref char Symbol(ulong index)
            => ref seek(Buffer.Edit,index);

        [MethodImpl(Inline)]
        public ref char Symbol(long index)
            => ref seek(Buffer.Edit,index);

        [MethodImpl(Inline)]
        public StringRef Substring(ulong index, ulong length)
            => strings.substring(this, index, length);

        [MethodImpl(Inline)]
        public StringRef Substring(long index, long length)
            => strings.substring(this,index,length);

        public ref char this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Symbol(index);
        }

        public ref char this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Symbol(index);
        }

        public StringRef this[long offset, long length]
        {
            [MethodImpl(Inline)]
            get => strings.substring(this, offset, length);
        }

        public StringRef this[ulong offset, ulong length]
        {
            [MethodImpl(Inline)]
            get => strings.substring(this, offset, length);
        }

        [MethodImpl(Inline)]
        public bool Store(ReadOnlySpan<char> src, uint offset)
            => strings.store(src,offset,this);

        [MethodImpl(Inline)]
        public Label StoreLabel(ReadOnlySpan<char> src, uint offset)
            => strings.label(src, offset, this);
    }
}