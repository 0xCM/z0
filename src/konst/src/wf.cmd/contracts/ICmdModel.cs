//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;

    public interface ICmdModel
    {
        Type DataType {get;}

        IndexedView<FieldInfo> Fields {get;}
    }

    public interface ICmdModel<T> : ICmdModel
        where T : struct, ICmdSpec<T>
    {
        Type ICmdModel.DataType
            => typeof(T);

        IndexedView<FieldInfo> ICmdModel.Fields
            => typeof(T).DeclaredInstanceFields();
    }

    public interface ICmdModel<H,T> : ICmdModel<T>
        where T : struct, ICmdSpec<T>
        where H : struct, ICmdModel<H,T>
    {

    }
}