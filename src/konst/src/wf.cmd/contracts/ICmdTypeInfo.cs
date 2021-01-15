//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdTypeInfo : IDataType
    {
        CmdId CmdId {get;}

        Type DataType {get;}

        Index<FieldInfo> Fields {get;}
    }

    [Free]
    public interface ICmdDescriptor<T> : ICmdTypeInfo
        where T : struct, ICmdSpec<T>
    {
        CmdId ICmdTypeInfo.CmdId
            => Cmd.id<T>();

        Type ICmdTypeInfo.DataType
            => typeof(T);

        Index<FieldInfo> ICmdTypeInfo.Fields
            => typeof(T).DeclaredInstanceFields();
    }

    [Free]
    public interface ICmdTypeInfo<H,T> : ICmdDescriptor<T>, IDataType<H>
        where T : struct, ICmdSpec<T>
        where H : struct, ICmdTypeInfo<H,T>
    {

    }
}