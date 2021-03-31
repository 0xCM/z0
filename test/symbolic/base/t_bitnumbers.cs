//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class t_bitnumbers<X> : UnitTest<X,NumericClaims,ICheckNumeric>
        where X : t_bitnumbers<X>, new()
    {

        public const int PointCount = 500;

    }
}
