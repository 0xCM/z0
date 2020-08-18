//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EnumLiteralNames<E>
        where E : unmanaged, Enum
    {
        public readonly string[] Storage;

        [MethodImpl(Inline)]
        public EnumLiteralNames(string[] src)
            => Storage = src;
        
        public string this[ulong index]
        {
            [MethodImpl(Inline)]
            get => Storage[index];
        }

        [MethodImpl(Inline)]
        public ref string Name(ulong index)
            => ref Storage[index];
        
        public ReadOnlySpan<string> View
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        public Span<string> Edit
        {
            [MethodImpl(Inline)]
            get => Storage;
        }
    }
}