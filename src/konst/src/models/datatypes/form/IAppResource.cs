//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAppResource
    {
        string Name {get;}
    }

    public interface IAppResource<T> : IAppResource
    {
        T Data {get;}
    }
}