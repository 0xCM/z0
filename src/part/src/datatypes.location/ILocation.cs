//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ILocation : ITextual
    {
        dynamic Locator {get;}

        string ITextual.Format()
            => string.Format("{0}", Locator);
    }

    public interface ILocation<T> : ILocation
        where T : struct
    {
        new T Locator {get;}

        dynamic ILocation.Locator
            => Locator;
    }
}