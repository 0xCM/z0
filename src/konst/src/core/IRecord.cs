//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRecord
    {

    }

    [Free]
    public interface IRecord<T> : IRecord, IDataType<T>
        where T : struct, IRecord<T>
    {
        T IDataType<T>.Content
            => (T)this;
    }
}