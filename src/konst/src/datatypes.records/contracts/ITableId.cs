//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using api = Records;

    [Free]
    public interface ITableId : ITextual
    {
        Name RecordType {get;}

        Name Identifier {get;}

        string ITextual.Format()
            => Identifier.Format();
    }

    [Free]
    public interface ITableId<T> : ITableId
        where T : struct, IRecord<T>
    {
        Name ITableId.RecordType
            => typeof(T).Name;

        Name ITableId.Identifier
            => api.tableid(typeof(T)).Identifier;
    }

    [Free]
    public interface ITableId<I,T> : ITableId<T>
        where T : struct, IRecord<T>
        where I : unmanaged
    {
        I Index {get;}
    }
}