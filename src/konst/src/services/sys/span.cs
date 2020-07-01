//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static System.Runtime.InteropServices.MemoryMarshal;
            
    using static Konst;
    using static OpacityKind;
    
    partial struct sys
    {
        [MethodImpl(Options), Opaque(StringToCharSpan)]
        public static ReadOnlySpan<char> span(string src)
            => src;
    }
}