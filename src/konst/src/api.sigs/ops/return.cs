//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ApiSigs
    {
        [MethodImpl(Inline), Op]
        public static OperandSig @return(TypeSig type, params ModifierKind[] modifiers)
            => new OperandSig(ReturnIndicator, type, modifiers);
    }
}