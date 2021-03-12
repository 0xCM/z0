//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ILocation : ITextual
    {
        dynamic Locator {get;}

    }

    public interface ILocation<T> : ILocation
        where T : struct
    {
        new T Locator => (T)this;

        dynamic ILocation.Locator
            => Locator;
    }
}