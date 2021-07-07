//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = LookupTables;

    [StructLayout(LayoutKind.Sequential, Size=4)]
    public readonly struct LookupKey : ITextual
    {
        [MethodImpl(Inline)]
        public static LookupKey define(ushort row, ushort col)
            => @as<uint,LookupKey>((uint)row | ((uint)col) << 16);

        [MethodImpl(Inline)]
        public ushort Row()
            => (ushort)(data(this));

        [MethodImpl(Inline)]
        public ushort Col()
            => (ushort)(data(this) >> 16);

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => data(this) == Unspecified;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => data(this) != Unspecified;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        static uint data(LookupKey src)
            => @as<LookupKey,uint>(src);

        [MethodImpl(Inline)]
        static LookupKey key(uint src)
            => @as<uint,LookupKey>(src);

        const uint Unspecified = uint.MaxValue;

        public static LookupKey Empty => key(Unspecified);
    }
}