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

    public unsafe readonly struct ConstStringRef<S>
        where S : unmanaged
    {
        readonly MemoryAddress Base;

        public uint Length {get;}

        [MethodImpl(Inline)]
        internal ConstStringRef(MemoryAddress @base, uint length)
        {
            Base = @base;
            Length = length;
        }

        public ref readonly S this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Base.Ref<S>(), index);
        }

        public ref readonly S this[long index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Base.Ref<S>(), index);
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length*size<S>();
        }

        public ReadOnlySpan<S> View
        {
            [MethodImpl(Inline)]
            get => cover<S>(Base.Pointer<S>(), Length);
        }
    }
}