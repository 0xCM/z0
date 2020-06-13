//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    partial class Symbolic     
    {
        [MethodImpl(Inline), Op]
        public static asci4 asci(ReadOnlySpan<char> src, N4 n)        
            => AsciCodes.encode(n, src);            

        [MethodImpl(Inline), Op]
        public static asci8 asci(ReadOnlySpan<char> src, N8 n)        
            => AsciCodes.encode(n,src);            

        [MethodImpl(Inline), Op]
        public static asci16 asci(ReadOnlySpan<char> src, N16 n)        
            => AsciCodes.encode(n, src);            

        [MethodImpl(Inline), Op]
        public static asci32 asci(ReadOnlySpan<char> src, N32 n)        
            => AsciCodes.encode(n, src);            

        [MethodImpl(Inline), Op]
        public static asci64 asci(ReadOnlySpan<char> src, N64 n)        
            => AsciCodes.encode(n, src);            
    }
}