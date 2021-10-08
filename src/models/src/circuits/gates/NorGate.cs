//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Circuits.Gates;

    partial struct Circuits
    {
        public sealed class NorGate<T> : BinaryGate<NorGate<T>,T>
            where T : unmanaged
        {
            public override GateKind Kind
                => GateKind.Nor;

            [MethodImpl(Inline)]
            public override T Flow(T a, T b)
                => api.nor(a,b);
        }
    }
}