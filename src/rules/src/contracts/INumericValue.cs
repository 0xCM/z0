//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    public interface INumericValue
    {
        byte[] Content {get;}
    }

    public interface INumericValue<K> : INumericValue
        where K : unmanaged
    {
        K Kind {get;}
    }
}