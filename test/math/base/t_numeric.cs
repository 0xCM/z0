//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class t_numeric<X> : UnitTest<X,CheckVectors, ICheckVectors>
        where X : t_numeric<X>, new()
    {
        protected new TCheckNumeric Claim => CheckNumeric.Checker;
    }
}