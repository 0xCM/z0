//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;
    using static memory;

    public readonly struct Allocation<T> : IDisposable
        where T : unmanaged
    {
        readonly GCHandle _Handle;

        readonly uint _Size;

        [MethodImpl(Inline)]
        internal Allocation(GCHandle handle, uint size)
        {
            _Handle = handle;
            _Size = size;
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => _Handle.AddrOfPinnedObject();
        }

        public ref T First
        {
            [MethodImpl(Inline)]
            get => ref  @ref<T>(Address);
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => cover<T>(Address, _Size);
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => cover<T>(Address, _Size);
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => _Size;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Size/size<T>();
        }

        public void Dispose()
        {
            _Handle.Free();
        }
    }
}