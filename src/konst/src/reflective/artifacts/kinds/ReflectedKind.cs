//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;


    public enum ReflectedKind: byte
    {
        None,

        Type,

        Delegate,

        Method,

        MethodBody,

        Field,

        Property,

        Assembly,

        Event,

        Module,

        Interface,

        Enum,

        EnumLiteral
    }
}