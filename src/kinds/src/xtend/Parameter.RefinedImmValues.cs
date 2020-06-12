//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static ImmFunctionClass;

    partial class XTend
    {
        public static Imm8Value[] RefinedImmValues(this ParameterInfo param)           
        {
            if(param.IsRefinedImmediate())
                return param.ParameterType.GetEnumValues().Cast<byte>().ToImm8Values(ImmSourceKind.Refinement);
            else 
                return Arrays.empty<Imm8Value>();
        }
    }
}