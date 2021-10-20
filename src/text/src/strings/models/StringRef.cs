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

    public unsafe readonly struct StringRef
    {
        internal readonly MemoryAddress Base;

        [MethodImpl(Inline)]
        internal StringRef(MemoryAddress @base, uint length)
        {
            Base = @base;
            Length = length;
        }

        public uint Length {get;}

        public ref char this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Base.Ref<char>(), index);
        }

        public ref char this[long index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Base.Ref<char>(), index);
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Length*size<char>();
        }

        public Span<char> Edit
        {
            [MethodImpl(Inline)]
            get => cover<char>(Base.Pointer<char>(), Length);
        }

        public ReadOnlySpan<char> View
        {
            [MethodImpl(Inline)]
            get => cover<char>(Base.Pointer<char>(), Length);
        }
    }
}