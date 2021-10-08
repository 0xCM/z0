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
        public sealed class OrGate<T> : BinaryGate<OrGate<T>,T>
            where T : unmanaged
        {
            public override GateKind Kind
                => GateKind.Or;

            [MethodImpl(Inline)]
            public override T Flow(T a, T b)
                => api.or(a,b);
        }
    }
}