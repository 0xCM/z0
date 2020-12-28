//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

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
            => Records.tableid<T>().Identifier;
    }
}