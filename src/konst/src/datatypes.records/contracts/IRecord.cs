//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using System;

    using api = Records;

    public readonly struct FK<T>
    {
        public Type ForeignType => typeof(T);

        public uint Value {get;}

        public FK(uint location)
            => Value = location;
    }

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