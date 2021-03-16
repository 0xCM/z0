//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct BitSegment<T>
        where T : unmanaged
    {
        readonly BitFieldPart Part;

        public T State;

        [MethodImpl(Inline)]
        public BitSegment(BitFieldPart part, T state = default)
        {
            Part = part;
            State = state;
        }

        public Identifier Name
        {
            [MethodImpl(Inline)]
            get => Part.Name;
        }

        public byte FirstIndex
        {
            [MethodImpl(Inline)]
            get => Part.FirstIndex;
        }

        public byte LastIndex
        {
            [MethodImpl(Inline)]
            get => Part.LastIndex;
        }

        [MethodImpl(Inline)]
        public static implicit operator BitSegment<T>(BitFieldPart part)
            => new BitSegment<T>(part);
    }
}