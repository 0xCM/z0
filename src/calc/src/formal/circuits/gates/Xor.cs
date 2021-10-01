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
            public sealed class Xor<T> : BinaryGate<Xor<T>,T>
                where T : unmanaged
            {
                public override GateKind Kind
                    => GateKind.Xor;

                [MethodImpl(Inline)]
                public override T Flow(T a, T b)
                    => api.xor(a,b);
            }
        }
    }
}