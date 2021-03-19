//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Identifies a segment of bits within a context
    /// </summary>
    public struct BitSegment64
    {
        readonly BitFieldPart Part;

        public ulong State;

        [MethodImpl(Inline)]
        public BitSegment64(BitFieldPart part, ulong state)
        {
            Part = part;
            State = state;
        }


        [MethodImpl(Inline)]
        public bool Equals(BitSegment64 src)
            => State == src.State;


        public override bool Equals(object src)
            => src is BitSegment64 s && Equals(s);

        public override int GetHashCode()
            => State.GetHashCode();
    }
}