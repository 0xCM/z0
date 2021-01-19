//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XNumeric
    {
        [MethodImpl(Inline)]
        public static NumericApiKind ApiKind(this NumericKind kind)
            => NumericKinds.apikind(kind);
    }
}