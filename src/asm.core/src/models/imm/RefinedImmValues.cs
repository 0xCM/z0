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
        [Op]
        public static Index<Imm8R> RefinedImmValues(this ParameterInfo param)
        {
            if(param.IsRefinedImmediate())
                return param.ParameterType.GetEnumValues().Cast<byte>().Array().ToImm8Values(ImmRefinementKind.Refined);
            else
                return sys.empty<Imm8R>();
        }

        [Op]
        public static Index<Imm8R> ToImm8Values(this byte[] src, ImmRefinementKind kind)
            => src.Map(x => new Imm8R(x));
    }
}