//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ILocated
    {
        dynamic Location {get;}
    }

    public interface ILocated<T> : ILocated
    {
        new T Location {get;}

        dynamic ILocated.Location
            => Location;
    }
}