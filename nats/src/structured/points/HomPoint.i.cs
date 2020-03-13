//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IHomPoint<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        int Dimension => (int)Nats.nateval<N>();

        Span<T> Components {get;}
    }
}