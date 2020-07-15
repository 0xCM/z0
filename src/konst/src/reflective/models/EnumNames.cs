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

    public readonly struct EnumNames
    {        
        public readonly Type Enum;
        
        public readonly string[] Names;

        [MethodImpl(Inline)]
        public EnumNames(Type type, string[] src)
        {
            Enum = type;
            Names = src;
        }
    }
    
    public readonly struct EnumNames<E>
        where E : unmanaged, Enum
    {
        [MethodImpl(Inline)]
        public EnumNames(string[] src)
        {
            Names = src;
        }
        
        public readonly string[] Names;
    }
}