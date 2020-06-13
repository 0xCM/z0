//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    using static Control;

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static int encode(ReadOnlySpan<char> src, ref byte dst)
        {
            const int W = 16;
            const char Z = (char)0;

            var @null = Symbolic.first(src, Z);
            var count = @null == -1 ? src.Length : 0;
            if(count == 0)
                return 0;

            var consumed = 0;
            var remaining = count;
            
            for(int i=0; i<count; i++)
            {
                if(remaining<0) 
                    break;                
                
                var take =  remaining >= W ? W : remaining;
                encode(skip(src, consumed), (Hex4)take, out asci16 encoded);
                
                ref readonly var bytes = ref head(encoded.Encoded);                                
                ref var target = ref Unsafe.Add(ref dst, consumed);
                for(var k=0; k<take; k++)
                    seek(ref target, k) = skip(bytes, k);
                
                consumed += take;
                remaining -= take;
            }
            
            return consumed;
        }

        [MethodImpl(Inline), Op]
        public static int encode(ReadOnlySpan<char> src, Span<byte> dst)
        {
            const int W = 16;
            const char Z = (char)0;

            var @null = Symbolic.first(src, Z);
            var count = @null == -1 ? src.Length : 0;
            if(count == 0)
                return 0;

            var j = 0;
            var r = count;
            for(int i=0; i<count; i++)
            {
                if(r<0) 
                    break;                
                
                var seglen = r >= W ? W : r;
                var segSrc = src.Slice(j, seglen);            
                var segDst = dst.Slice(j, seglen);
                encode(segSrc, out asci16 encoded).CopyTo(segDst);
                
                j += seglen;
                r -= seglen;
            }
            return j;
        }

        /// <summary>
        /// Encodes each source string and packs the result into the target
        /// </summary>
        /// <param name="src">The encoding source</param>
        /// <param name="dst">The encoding target</param>
        [MethodImpl(Inline), Op]
        public static int encode(ReadOnlySpan<string> src, Span<byte> dst)
        {
            var j = 0;
            for(int i=0; i<src.Length; i++)
                j += encode(skip(src, i), dst.Slice(j));
            return j + 1;
        }

        /// <summary>
        /// Encodes each source string and packs the result into the target, 
        /// interspersed by a supplied delimiter
        /// </summary>
        /// <param name="src">The encoding source</param>
        /// <param name="dst">The encoding target</param>
        [MethodImpl(Inline), Op]
        public static int encode(ReadOnlySpan<string> src, Span<byte> dst, byte delimiter)
        {
            var j = 0;
            for(int i=0; i<src.Length; i++)
            {                
                j += encode(skip(src, i), dst.Slice(j));
                seek(dst, ++j) = delimiter;
            }
            return j + 1;
        }        
    }
}