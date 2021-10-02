//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Circuits
    {
        public readonly struct Gate
        {
            public readonly GateKind Kind;

            public readonly byte PinWidth;

            public readonly byte InputCount;

            public readonly byte OutputCount;

            [MethodImpl(Inline)]
            public Gate(GateKind kind, byte width, byte ins, byte outs)
            {
                Kind = kind;
                InputCount = ins;
                OutputCount = outs;
                PinWidth = width;
            }
        }
    }
}