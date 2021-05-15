//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class t_core<X> : UnitTest<X,NumericClaims,ICheckNumeric>
        where X : t_core<X>, new()
    {

    }
}