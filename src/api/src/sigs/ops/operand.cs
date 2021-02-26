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

    partial struct ApiSigs
    {
        [MethodImpl(Inline), Op]
        public static OperandSig operand(Name name, TypeSig type, params ModifierKind[] modifiers)
            => new OperandSig(name, type, modifiers);
    }
}
