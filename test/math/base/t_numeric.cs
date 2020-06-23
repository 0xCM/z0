//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    public abstract class t_numeric<X> : UnitTest<X,CheckVectors, TCheckVectors>
        where X : t_numeric<X>, new()
    {
        protected new TCheckNumeric Claim => CheckNumeric.Checker;
    }

}