//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class t_uint<X> : UnitTest<X,CheckNumeric,ICheckNumeric>
        where X : t_uint<X>, new()
    {

        public const int PointCount = 500;

    }
}
