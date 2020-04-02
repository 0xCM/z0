//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XKind
    {
        [MethodImpl(Inline)]
        public static NumericKind ToNumericKind(this FixedWidth width, NumericIndicator indicator) 
            => NumericTypes.kind(width,indicator);
    }
}