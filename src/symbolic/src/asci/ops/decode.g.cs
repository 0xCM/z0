//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
     
    using static Seed;
    using static Control;

    partial class AsciCodes
    {

        [MethodImpl(Inline)]
        public static char @char(byte src)
            => (char)src;
        
        [MethodImpl(Inline)]
        public static void decode(ReadOnlySpan<byte> src, Span<char> dst)
        {            
            var count = length(src,dst);
            for(var i=0; i<count; i++)            
                seek(dst,i) = @char(skip(src,i));
        }

        [MethodImpl(Inline)]
        public static void decode(ReadOnlySpan<ushort> src, Span<char> dst)
        {
            for(var i=0; i<src.Length; i++)            
            {
                
            }
            
        }

        public static void decode(ReadOnlySpan<uint> src, Span<char> dst)
        {
            for(var i=0; i<src.Length; i++)            
            {
                
            }
            
        }

        public static void decode(ReadOnlySpan<ulong> src, Span<char> dst)
        {
            for(var i=0; i<src.Length; i++)            
            {
                
            }
            
        }

    }
}