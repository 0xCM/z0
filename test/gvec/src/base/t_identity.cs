//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class t_identity<U> : UnitTest<U,CheckVectorsHost,ICheckVectors>
        where U : t_identity<U>
    {

    }
}