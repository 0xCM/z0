//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Enums
    {
        [MethodImpl(Inline)]
        public static EnumPrimalKind kind<E>(E e = default)
            where E : unmanaged, Enum 
        {
            var tc = Type.GetTypeCode(typeof(E).GetEnumUnderlyingType());
            return (EnumPrimalKind)Control.primal(tc);
        }
    }
}