//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ICliRecord<T>  : IRecord<T>
        where T : unmanaged, ICliRecord<T>
    {

    }

    public interface ICliRecord<T,K> : ICliRecord<T>
        where T : unmanaged, ICliRecord<T>
        where K : unmanaged, ICliTableKind<K>
    {

    }

}