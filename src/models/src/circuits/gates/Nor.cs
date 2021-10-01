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
            public sealed class Nor<T> : BinaryGate<Nor<T>,T>
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
}