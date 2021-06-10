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

    [StructLayout(LayoutKind.Sequential, Size = Size, Pack=1)]
    public struct WordBlock8
    {
        public const ushort Size = Pow2.T04;

        public Span<ushort> Buffer
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
            get => ref seek(Buffer,index);
        }


        public static WordBlock8 Empty => default;
    }
}