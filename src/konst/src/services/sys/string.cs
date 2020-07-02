//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
            
    using static Konst;
    using static OpacityKind;
    
    partial struct sys
    {
        [MethodImpl(Options), Opaque(CreateString), Closures(AllNumeric)]
        public static string @string<T>(T src)
            => src?.ToString() ?? EmptyString;

        [MethodImpl(Options), Opaque(CharPointerToString)]
        public static unsafe string @string(char* pSrc)
            => new string(pSrc);
        
        [MethodImpl(Options), Opaque(CharSpanToString)]
        public static string @string(ReadOnlySpan<char> src)
            => src.ToString();
    }
}