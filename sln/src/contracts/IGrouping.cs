//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IGrouping<T>
        where T : struct, IGrouping<T>
    {
        string GroupName => typeof(T).Name;
    }

    public interface IGroupMember<M,G>
        where M : struct, IGroupMember<M,G>
        where G : struct, IGrouping<G>
    {

    }
}