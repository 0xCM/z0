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
        public readonly struct Fx<R> : ISignature<Fx<R>,R>
            where R : unmanaged, IDataCell
        {
            public TypeWidth ResultWidth
                => (TypeWidth)default(R).BitWidth;
        }
    }
}