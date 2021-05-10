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
}