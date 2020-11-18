//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataType : IReified
    {
    }

    [Free]
    public interface IDataType<T> : IDataType, IReified<T>
        where  T : struct, IDataType<T>
    {

    }
}