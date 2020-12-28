//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct EnumLiteralNames<E> : IIndex<string>
        where E : unmanaged, Enum
    {
        readonly Index<string> Data;

        [MethodImpl(Inline)]
        public EnumLiteralNames(string[] src)
            => Data = src;

        public string[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public string this[ulong index]
        {
            [MethodImpl(Inline)]
            get => Data[index];
        }

        [MethodImpl(Inline)]
        public ref string Name(ulong index)
            => ref Data[index];

        public ReadOnlySpan<string> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<string> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}