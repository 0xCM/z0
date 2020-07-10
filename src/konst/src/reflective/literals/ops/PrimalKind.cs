//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    
    partial class XTend
    {
        [MethodImpl(Inline)]
        public static PrimalKindId ToKind(this TypeCode src)
            => (PrimalKindId)src;

        [MethodImpl(Inline)]
        public static TypeCode ToTypeCode(this PrimalKindId src)
            => (TypeCode)src;

        [MethodImpl(Inline)]
        public static string Format(this PrimalKindId src)
            => $"{src}";            
    }
}