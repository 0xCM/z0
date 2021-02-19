//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;

    public interface INumericValue
    {
        BinaryCode Content {get;}
    }

    public interface INumericValue<K> : INumericValue
        where K : unmanaged
    {
        K Kind {get;}
    }
}