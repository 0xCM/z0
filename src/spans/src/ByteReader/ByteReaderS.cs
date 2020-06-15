//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;
    using static refs;

    [ApiHost("bytereader.spanned")]
    readonly struct ByteReaderS : IApiHost<ByteReaderS>
    {
        [MethodImpl(Inline)]
        public static T Read<T>(ReadOnlySpan<byte> src)
        {
            if(typeof(T) == typeof(byte))
                return  generic<T>(Read1(src));
            else if(typeof(T) == typeof(ushort))
                return  generic<T>(Read2(src));
            else if(typeof(T) == typeof(uint))
                return  generic<T>(Read4(src));
            else if(typeof(T) == typeof(ulong))
                return  generic<T>(Read8(src));
            else
                return default;
        }

        [MethodImpl(Inline), Op]
        public static ulong U64(ReadOnlySpan<byte> src)
        {
            var count = min(8, src.Length);
            if(count == 0)
                return 0;

            var dst = 0ul;
            for(var i=0; i<count; i++)
                refs.seek8(ref dst, i) = refs.skip(src,i);            
            
            return dst;
        }
        
        [MethodImpl(Inline), Op]
        public static ulong Read(ReadOnlySpan<byte> src, byte count)
        {
            if(count == 1)
                return Read1(src);
            else if(count == 2)
                return Read2(src);
            else if(count == 3)
                return Read3(src);
            else if(count == 4)
                return Read4(src);
            else if(count == 5)
                return Read5(src);
            else if(count == 6)
                return Read6(src);
            else if(count == 7)
                return Read7(src);
            else if(count == 8)
                return Read8(src);
            else
                return 0;
        }

        [MethodImpl(Inline), Op]
        public static ulong Read1(ReadOnlySpan<byte> src)
        {
            var dst = 0ul;
            seek8(ref dst, 0) = skip(src,0);
            return dst;        
        }

        [MethodImpl(Inline), Op]
        public static ulong Read2(ReadOnlySpan<byte> src)
        {
            var dst = 0ul;
            var i = 0;
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            return dst;        
        }

        [MethodImpl(Inline), Op]
        public static ulong Read3(ReadOnlySpan<byte> src)
        {
            var dst = 0ul;
            var i = 0;
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            return dst;        
        }

        [MethodImpl(Inline), Op]
        public static ulong Read4(ReadOnlySpan<byte> src)
        {
            var dst = 0ul;
            var i = 0;
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            return dst;        
        }

        [MethodImpl(Inline), Op]
        public static ulong Read5(ReadOnlySpan<byte> src)
        {
            var dst = 0ul;
            var i = 0;
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            return dst;        
        }


        [MethodImpl(Inline), Op]
        public static ulong Read6(ReadOnlySpan<byte> src)
        {
            var dst = 0ul;
            var i = 0;
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            return dst;        
        }

        [MethodImpl(Inline), Op]
        public static ulong Read7(ReadOnlySpan<byte> src)
        {
            var dst = 0ul;
            var i = 0;
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            return dst;        
        }

        [MethodImpl(Inline), Op]
        public static ulong Read8(ReadOnlySpan<byte> src)
        {
            var dst = 0ul;
            var i = 0;
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            seek8(ref dst, i++) = skip(src,i);
            return dst;        
        }

        [MethodImpl(Inline), Op]
        static ulong Read8_NoInc(ReadOnlySpan<byte> src)
        {
            var dst = 0ul;
            seek8(ref dst, 0) = skip(src,0);            
            seek8(ref dst, 1) = skip(src,1);            
            seek8(ref dst, 2) = skip(src,2);            
            seek8(ref dst, 3) = skip(src,3);            
            seek8(ref dst, 4) = skip(src,4);            
            seek8(ref dst, 5) = skip(src,5);            
            seek8(ref dst, 6) = skip(src,6);            
            seek8(ref dst, 7) = skip(src,7);    
            return dst;        
        }

        [MethodImpl(Inline)]
        static int min(int a, int b)
            => a <= b ? a : b;
    }
}