//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct CheckProvider
    {
        public static CheckProvider create()
            => new CheckProvider();

        public ICheckEquatable CheckEquatable => new CheckEquatable();

    }
}