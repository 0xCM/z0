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
            public sealed class Mux<T> : TernaryGate<Mux<T>,T>
                where T : unmanaged
            {
                public override GateKind Kind
                    => GateKind.Mux;

                [MethodImpl(Inline)]
                public override T Flow(T a, T b, T c)
                    => api.mux(a,b,c);
            }
        }
    }
}