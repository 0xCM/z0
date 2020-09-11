//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class t_permute<U> : UnitTest<U,CheckVectors,ICheckVectors>
        where U : t_permute<U>,new()
    {

    }
}