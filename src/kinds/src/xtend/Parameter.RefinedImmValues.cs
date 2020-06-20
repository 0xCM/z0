//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    partial class XTend
    {
        public static Imm8Value[] RefinedImmValues(this ParameterInfo param)           
        {
            if(param.IsRefinedImmediate())
                return param.ParameterType.GetEnumValues().Cast<byte>().ToImm8Values(ImmRefinementKind.Refined);
            else 
                return Arrays.empty<Imm8Value>();
        }
    }
}