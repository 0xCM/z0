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

    public readonly struct Container<T> : IDisposable
    {
        readonly GCHandle Handle;

        readonly MemoryAddress Address;

        readonly Index<T> Buffer;

        [MethodImpl(Inline)]
        public Container(T[] content)
            : this()
        {
            Handle = GCHandle.Alloc(this);
            Address = Handle.AddrOfPinnedObject();
            Buffer = content;
        }

        [MethodImpl(Inline)]
        public Element GetElement(uint index)
            => new Element(Address, index);

        ref T this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Buffer[index];
        }

        public struct Element
        {
            readonly MemoryAddress Parent;

            readonly uint Index;

            public ref T Cell
            {
                [MethodImpl(Inline)]
                get => ref Parent.Ref<Container<T>>()[Index];
            }

            [MethodImpl(Inline)]
            public Element(MemoryAddress parent, uint index)
            {
                Parent = parent;
                Index = index;
            }
        }


        public void Dispose()
        {
            Handle.Free();
        }
    }
}