//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost(ApiNames.Sigs, true)]
    public readonly partial struct ApiSigs
    {
        const string ReturnIndicator = "##return";

        [MethodImpl(Inline), Op]
        public static OpenParameter open(ushort position, Name name)
            => new OpenParameter(position, name);

        [MethodImpl(Inline), Op]
        public static ClosedParameter close(OpenParameter src, TypeSig closure)
            => new ClosedParameter(src.Position, src.Name, closure);

        [MethodImpl(Inline), Op]
        public static TypeSig type(Name name, params ITypeParameter[] parameters)
            => new TypeSig(name, parameters);

        [MethodImpl(Inline), Op]
        public static OperandSig ret(TypeSig type, params ModifierKind[] modifiers)
            => new OperandSig(ReturnIndicator, type, modifiers);

        [MethodImpl(Inline), Op]
        public static OperandSig operand(Name name, TypeSig type, params ModifierKind[] modifiers)
            => new OperandSig(name,type, modifiers);

        [MethodImpl(Inline), Op]
        public static OperationSig operation(Name name, OperandSig @return, params OperandSig[] operands)
            => new OperationSig(name, @return, operands);

        [Op]
        static ITextBuffer buffer(uint capacity = 120)
            => text.buffer(capacity);
    }
}