//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;


    [ApiHost(ApiNames.Sigs, true)]
    public readonly partial struct ApiSigs
    {
        [MethodImpl(Inline), Op]
        public static OperandSig operand(Name name, TypeSig type, SigModifier modifier)
            => new OperandSig(name,type, modifier);

        [MethodImpl(Inline), Op]
        public static TypeSig type(Name name, Index<TypeParameter> parameters)
            => new TypeSig(name, parameters);

        [MethodImpl(Inline), Op]
        public static MethodSig method(Name name, Index<OperandSig> operands, OperandSig @return)
            => new MethodSig(name, operands, @return);
    }
}