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
        [MethodImpl(Inline), Op]
        public static void decode(AsciCode2 src, Span<char> dst)
        {
            var data = cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
        } 

        [MethodImpl(Inline), Op]
        public static int decode(AsciCode4 src, Span<char> dst)
        {
            var data = cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
            return 4;
        } 


        [MethodImpl(Inline), Op]
        public static void decode(AsciCode5 src, Span<char> dst)
        {
            var data = cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
            seek(dst,4) = skip(data,4);
        } 

        [MethodImpl(Inline), Op]
        public static char decode(AsciCode2 src, byte index)
            => (char)code(src,index);

        [MethodImpl(Inline), Op]
        public static char decode(AsciCode4 src, byte index)
            => (char)code(src,index);

        [MethodImpl(Inline), Op]
        public static int decode(in AsciCode8 src, Span<char> dst)
        {
            var data = cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
            seek(dst,4) = skip(data,4);
            seek(dst,5) = skip(data,5);
            seek(dst,6) = skip(data,6);
            seek(dst,7) = skip(data,7);
            return 8;
        } 

        [MethodImpl(Inline), Op]
        public static char decode(in AsciCode16 src, byte index)
            => (char)code(src,index);

        [MethodImpl(Inline), Op]
        public static int decode(in AsciCode16 src, Span<char> dst)
        {
            var data = SymBits.vinflate(src.Data);
            var bytes = bytespan(data);
            var chars = cast<char>(bytes);
            var count = 0;    
            for(var i=0; i<chars.Length; i++, count++)
            {
                ref readonly var c = ref skip(chars,i);
                if((AsciCharCode)c != AsciCharCode.Null)
                    seek(dst,i) = c;
                else
                    break;
            }
            return count;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in AsciCode16 src)
        {
            var data = SymBits.vinflate(src.Data);
            var bytes = bytespan(data);
            var chars = cast<char>(bytes);    
            var len = chars.Length;
            for(var i=0; i<len; i++)
            {
                if((AsciCharCode)skip(chars,i) == AsciCharCode.Null)
                {
                    len = i;
                    break;
                }
            }

            return chars.Slice(0, len);
        }

        readonly struct Seg512
        {
            readonly Vector256<ushort> Lo;

            readonly Vector256<ushort> Hi;

            [MethodImpl(Inline), Op]
            public Seg512(Vector256<ushort> lo, Vector256<ushort> hi)
            {
                this.Lo = lo;
                this.Hi = hi;
            }
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in AsciCode32 src)
        {            
            var lo = SymBits.vinflate(Vector256.GetLower(src.Data));
            var hi = SymBits.vinflate(Vector256.GetUpper(src.Data));
            var data = new Seg512(lo,hi);
            return cast<char>(Control.bytespan(data));
        }
    }
}