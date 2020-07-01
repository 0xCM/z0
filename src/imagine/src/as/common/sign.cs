//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial struct As
    {
        [MethodImpl(Inline), Op]
        public static NumericSign sign(sbyte src)
            => src < 0 ? new NumericSign(NumericSignKind.Negative)
            : src > 0 ? new NumericSign(NumericSignKind.Positive)
            : new NumericSign(0);
    }
}