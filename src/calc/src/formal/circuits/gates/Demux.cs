//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = FormalModels.Gates;

    partial struct FormalModels
    {
        partial struct Circuits
        {
            public sealed class Demux<T> : Gate<Demux<T>,T>
                where T : unmanaged
            {
                public override GateKind Kind
                    => GateKind.Nand;

                [MethodImpl(Inline)]
                public Pair<T> Flow(T a, T b)
                    => api.demux(a,b);
            }
        }
   }
}