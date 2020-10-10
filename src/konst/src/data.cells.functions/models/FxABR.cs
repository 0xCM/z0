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
        public readonly struct Fx<A,B,R> : ISignature<Fx<A,B,R>,A,B,R>
            where R : unmanaged, IDataCell
            where A : unmanaged, IDataCell
            where B : unmanaged, IDataCell
        {
            public TypeWidth ResultWidth
                => (TypeWidth)default(R).BitWidth;

            public TypeWidth Width(N0 n)
                => (TypeWidth)default(A).BitWidth;

            public TypeWidth Width(N1 n)
                => (TypeWidth)default(B).BitWidth;
        }
    }
}