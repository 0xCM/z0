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
        StringRef RecordType {get;}

        StringRef Identifier {get;}

        string ITextual.Format()
            => Identifier.Format();
    }

    [Free]
    public interface ITableId<T> : ITableId
        where T : struct, IRecord<T>
    {
        StringRef ITableId.RecordType
            => typeof(T).Name;

        StringRef ITableId.Identifier
            => Table.id<T>().Identifier;
    }
}