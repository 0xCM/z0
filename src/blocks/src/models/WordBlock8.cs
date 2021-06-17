//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using B = WordBlock8;

    [StructLayout(LayoutKind.Sequential, Size = Size)]
    public struct WordBlock8
    {
        public static N8 N => default;

        public const ushort Size = Pow2.T04;

        public Span<ushort> Data
        {
            [MethodImpl(Inline)]
            get => recover<ushort>(Bytes);
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => bytes(this);
        }

        public ref ushort this[byte index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data,index);
        }

        [MethodImpl(Inline)]
        public Span<T> Edit<T>()
            where T : unmanaged
                => recover<T>(Bytes);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> View<T>()
            where T : unmanaged
                => recover<T>(Bytes);

        public static B Empty => default;
    }
}