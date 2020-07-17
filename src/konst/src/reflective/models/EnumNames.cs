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
    using static z;

    [ApiHost]
    public readonly struct EnumNames
    {   
        [MethodImpl(Inline)]
        public static Z0.EnumNames<E> get<E>()                   
            where E : unmanaged, Enum
                => new Z0.EnumNames<E>(Enum.GetNames(typeof(E)));    
        public readonly Type EnumType;
        
        public readonly string[] Names;

        [MethodImpl(Inline)]
        public EnumNames(Type type, string[] src)
        {            
            EnumType = type;
            Names = src;
        }

        public string this[uint index]
        {
            [MethodImpl(Inline)]
            get => Names[index];
        }

        [MethodImpl(Inline)]
        public string Name(uint index)
            => this[index];
    }
}