//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class t_vectors<U> : UnitTest<U,CheckVectorsHost,ICheckVectors>
        where U : t_vectors<U>,new()
    {

    }
}