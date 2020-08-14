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
        FieldInfo Definition {get;}

        RenderWidth Width {get;}
        
        string Name 
            => Definition.Name;        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ITableField<F> : ITableField
        where F : unmanaged, Enum
    {
        F Id {get;}
    }
}