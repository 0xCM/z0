//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    public abstract class t_mathsvc<X> : UnitTest<X,CheckNumeric,TCheckNumeric>    
        where X : t_mathsvc<X>, new()
    {


    }
}
