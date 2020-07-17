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

    public readonly struct EnumNames<E>
        where E : unmanaged, Enum
    {
        [MethodImpl(Inline)]
        public EnumNames(string[] src)
        {
            Names = src;
        }
        
        public readonly string[] Names;

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