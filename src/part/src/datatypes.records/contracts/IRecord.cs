//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using api = RecordUtilities;

    [Free]
    public interface IRecord
    {
        [Op]
        TableId TableId {get;}

        RecordFields Fields();
    }

    [Free]
    public interface IRecord<T> : IRecord
        where T : struct, IRecord<T>
    {
        TableId IRecord.TableId
            => api.tableid(typeof(T));

        RecordFields IRecord.Fields()
            => api.fields<T>();
    }
}