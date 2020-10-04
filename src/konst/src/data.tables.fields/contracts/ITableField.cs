//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITableField
    {
        Type TableType {get;}

        string FieldName {get;}

        Type DataType {get;}

        ByteSize FieldSize {get;}

        RenderWidth<ushort> RenderWidth {get;}
    }

    [Free]
    public interface ITableField<T> : ITableField
        where T : struct, ITable
    {
        Type ITableField.TableType
            => typeof(T);

    }

    [Free]
    public interface ITableField<F,T> : ITableField<T>
        where T : struct, ITable
        where F : unmanaged, Enum
    {

    }

    [Free]
    public interface ITableField<F,T,V> : ITableField<F,T>
        where T : struct, ITable
        where F : unmanaged, Enum
    {
        Type ITableField.DataType
            => typeof(V);

        ByteSize ITableField.FieldSize
            => z.size<V>();
    }
}