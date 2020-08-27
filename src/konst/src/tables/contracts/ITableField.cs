//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Security;

    using static Konst;

    [SuppressUnmanagedCodeSecurity]
    public interface ITableField
    {
        Type TableType {get;}

        StringRef FieldName {get;}

        Type DataType {get;}

        ByteSize FieldSize {get;}

        RenderWidth<ushort> RenderWidth {get;}

        Address64 FieldOffset
            => Interop.offset(TableType, FieldName);

        Address16 FieldId
            => (Address16)FieldOffset;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITableField<T> : ITableField
        where T : struct, ITable
    {
        Type ITableField.TableType
            => typeof(T);

        Address64 ITableField.FieldOffset
            => Interop.offset<T>(FieldName.Format());
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITableField<F,T> : ITableField<T>
        where T : struct, ITable
        where F : unmanaged, Enum
    {
        new F FieldId {get;}
    }

    [SuppressUnmanagedCodeSecurity]
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