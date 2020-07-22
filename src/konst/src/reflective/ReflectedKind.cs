//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
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