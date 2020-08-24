//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiDataType]
    public readonly struct WfToken : ITextual
    {
        public readonly ulong Value;

        public static WfToken Empty => default;

        [MethodImpl(Inline)]
        public WfToken(ulong value)
        {
            Value = value;
        }

        public WfPartKind Kind
        {
            [MethodImpl(Inline)]
            get => (WfPartKind)((uint)Value >> 24);
        }

        public Address32 Offset
        {
            [MethodImpl(Inline)]
            get => (uint)Value & BitMasks.Lo24u;
        }

        public uint Id
        {
            [MethodImpl(Inline)]
            get => (uint)(Value >> 32);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Value == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Value != 0;
        }

        public string Format()
            => text.format("{0}:{1} {2}", Kind.ToString(), Offset, Id.FormatAsmHex());
    }
}