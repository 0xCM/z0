//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IScope
    {
        uint Id => 0;
    }

    public interface IScope<T> : IScope
        where T : IScope<T>, new()
    {

    }
}