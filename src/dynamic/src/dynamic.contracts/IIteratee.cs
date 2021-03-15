//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static SFx;

    public interface IIteratee<T> : IAction<T,T,T>
        where T : unmanaged
    {

    }
}