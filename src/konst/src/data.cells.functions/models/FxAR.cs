//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct CellFunctions
    {
        public readonly struct Fx<A,R> : ISignature<Fx<A,R>,A,R>
            where R : unmanaged, IDataCell
            where A : unmanaged, IDataCell
        {
            public TypeWidth ResultWidth
                => (TypeWidth)default(R).BitWidth;

            public TypeWidth Width(N0 n0)
                => (TypeWidth)default(A).BitWidth;
        }
    }
}