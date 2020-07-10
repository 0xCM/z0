//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial class XTend
    {

        [MethodImpl(Inline)]
        public static NumericKind ToNumericKind(this NumericWidth width, NumericIndicator indicator) 
            => NumericKinds.kind(width, indicator);            
    }
}