//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static NumericKind ToNumericKind(this NumericClass k)            
            => NumericClasses.classified(k).NumericKind();

        [MethodImpl(Inline)]
        public static NumericKind ToNumericKind(this NumericWidth width, NumericIndicator indicator) 
            => NumericKinds.kind(width,indicator);            
    }
}