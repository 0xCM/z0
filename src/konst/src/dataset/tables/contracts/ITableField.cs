//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public interface ITableField
    {
        FieldInfo Definition {get;}

        RenderWidth Width {get;}
        
        string Name 
            => Definition.Name;        
    }

    public interface ITableField<F> : ITableField
        where F : unmanaged, Enum
    {

        F Id {get;}
    }
}