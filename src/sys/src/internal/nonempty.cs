//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
            
    using static OpacityKind;
    
    partial struct xsys
    {
        [MethodImpl(Options), Opaque(EmptyStringTest)]
        public static bool nonempty(string src)
            => !string.IsNullOrWhiteSpace(src);
    }
}