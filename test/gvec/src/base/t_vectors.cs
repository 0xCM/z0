//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Root;

    public abstract class t_vectors<U> : UnitTest<U,CheckVectors,ICheckVectors>
        where U : t_vectors<U>,new()
    {

    }
}