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
            public sealed class Or<T> : BinaryGate<Or<T>,T>
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
}