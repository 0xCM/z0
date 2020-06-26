//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class Enums
    {

        [MethodImpl(Inline)]
        public static EnumScalarKind kind(Type e)
        {
            var tc = Type.GetTypeCode(e.GetEnumUnderlyingType());
            return (EnumScalarKind)Root.primal(tc);
        }

        [MethodImpl(Inline)]
        public static EnumScalarKind kind<E>(E e = default)
            where E : unmanaged, Enum 
                => kind(typeof(E));
    }
}