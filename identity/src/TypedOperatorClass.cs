//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    public static class TypedOperatorClassOps
    {
        public static string Format(this OperatorTypeClass src)
            =>  src.IsNone 
                ? string.Empty 
                : "f:" +  Identity.identify(src.OperandType).Format().Replicate(src.OperatorClass.ArityValue() + 1).Intersperse(ArrowSymbols.AsciArrow).Concat();
    }
}