//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public abstract class t_bitgrids_base<U> : t_bitcore<U>
        where U : t_bitgrids_base<U>, new()
    {
        protected static NatSeq<N2,N1,N7> n217 => default;

        protected static NatSeq<N2,N1,N3> n213 = default;
    }
}