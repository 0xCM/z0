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
    public interface ICmdDescriptor
    {
        CmdId CmdId {get;}

        Type DataType {get;}

        IndexedView<FieldInfo> Fields {get;}
    }

    [Free]
    public interface ICmdDescriptor<T> : ICmdDescriptor
        where T : struct, ICmdSpec<T>
    {
        CmdId ICmdDescriptor.CmdId
            => Cmd.id<T>();

        Type ICmdDescriptor.DataType
            => typeof(T);

        IndexedView<FieldInfo> ICmdDescriptor.Fields
            => typeof(T).DeclaredInstanceFields();
    }

    [Free]
    public interface ICmdDescriptor<H,T> : ICmdDescriptor<T>
        where T : struct, ICmdSpec<T>
        where H : struct, ICmdDescriptor<H,T>
    {

    }
}