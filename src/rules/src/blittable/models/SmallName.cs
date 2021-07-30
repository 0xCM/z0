//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public struct SmallName : IName<SmallName,Cell128>
    {
        public const byte MaxLength = 15;

        public Cell128 Storage;

        public byte PointSize
            => 1;

        [MethodImpl(Inline)]
        internal SmallName(in Cell128 data)
        {
            Storage = data;
        }

        public uint Length
        {
            [MethodImpl(Inline)]
            get => Storage.Cell(w8, 15);
        }

        [MethodImpl(Inline)]
        public static implicit operator SmallName(string src)
            => BZ.name(src);

        [MethodImpl(Inline)]
        public static implicit operator SmallName(ReadOnlySpan<char> src)
            => BZ.name(src);

        [MethodImpl(Inline)]
        public static implicit operator Name<Cell128>(SmallName src)
            => new Name<Cell128>(src.Storage, src.Length, src.PointSize);
    }
}