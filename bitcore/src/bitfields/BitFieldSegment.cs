//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    using static As;

    public readonly struct BitFieldSegment : IBitFieldSegment
    {
        public byte Index {get;}

        public string Name {get;}

        public byte StartPos {get;}

        public byte EndPos {get;}

        public byte Width
        {
            [MethodImpl(Inline)]
            get => (byte)(EndPos - StartPos + 1);
        }

        [MethodImpl(Inline)]
        public static BitFieldSegment Define(byte index, string name, byte start, byte end)
            => new BitFieldSegment(index, name, start, end);

        [MethodImpl(Inline)]
        BitFieldSegment(byte index, string name, byte first, byte last)
        {
            this.Index = index;
            this.Name = name;
            this.StartPos = first;
            this.EndPos = last;
        }

        public string Format()
            => BitField.format(this);

        public override string ToString()
            => Format();
    }
}