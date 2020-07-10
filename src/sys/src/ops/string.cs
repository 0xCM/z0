//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
            
    using static Part;
    using static OpacityKind;
    
    partial struct sys
    {
        /// <summary>
        /// Projects the source onto its textual representation
        /// </summary>
        /// <param name="src">The source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(NotInline), Opaque(CreateString), Closures(AllNumeric)]
        public static string @string<T>(T src)
            => src?.ToString() ?? EmptyString;

        [MethodImpl(NotInline), Opaque(CharPointerToString)]
        public static unsafe string @string(char* pSrc)
            => new string(pSrc);
        
        [MethodImpl(NotInline), Opaque(CharSpanToString)]
        public static string @string(ReadOnlySpan<char> src)
            => src.ToString();
    }
}