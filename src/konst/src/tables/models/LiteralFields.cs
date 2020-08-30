//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct LiteralFields
    {
        public readonly FieldInfo[] Data;

        [MethodImpl(Inline)]
        public static implicit operator LiteralFields(FieldInfo[] src)
            => new LiteralFields(src);

        [MethodImpl(Inline)]
        public LiteralFields(FieldInfo[] src)
            => Data = src;

        public Count32 Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<FieldInfo> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<FieldInfo> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref FieldInfo this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}