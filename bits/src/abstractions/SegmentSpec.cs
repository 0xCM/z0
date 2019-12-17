//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    using static As;

    public readonly struct SegmentSpec 
    {
        public readonly ushort FirstPos;

        public readonly ushort LastPos;

        [MethodImpl(Inline)]
        public static implicit operator SegmentSpec((ushort first, ushort last) src)
            => new SegmentSpec(src.first, src.last);

        [MethodImpl(Inline)]
        public SegmentSpec(ushort first, ushort last)
        {
            this.FirstPos = first;
            this.LastPos = last;
        }

        public ushort Width
        {
            [MethodImpl(Inline)]
            get => uint16(LastPos - FirstPos + 1);
        }

        public void Deconstruct(out ushort first, out ushort last)
        {
            first = FirstPos;
            last = LastPos;
        }

        public string Format()
            => bracket(concat(zfunc.format(FirstPos), dots(), zfunc.format(LastPos)));
    }
}