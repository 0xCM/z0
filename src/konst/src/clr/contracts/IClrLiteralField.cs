//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface IClrField
    {
        FieldInfo Definition {get;}
    }

    public interface IClrLiteralField<T> : IClrField
    {
        T Value {get;}
    }
}