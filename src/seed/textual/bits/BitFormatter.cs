//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Control;
    
    [ApiHost]
    public readonly struct BitFormatter : IApiHost<BitFormatter>, IBitFormatter
    {
        public static BitFormatter Service => default(BitFormatter);

        public static string unsigned(object src, TypeCode type)
        {
            if(type == TypeCode.Byte)
                return Formatters.BitFormatter<byte>().Format((byte)src);
            else if(type == TypeCode.UInt16)
                return Formatters.BitFormatter<ushort>().Format((ushort)src);
            else if(type == TypeCode.UInt32)
                return Formatters.BitFormatter<uint>().Format((uint)src);
            else if(type == TypeCode.UInt64)
                return Formatters.BitFormatter<ulong>().Format((ulong)src);
            else
                return string.Empty;
        }

        [MethodImpl(Inline)]
        public static string format<T>(T src)
            where T : struct
                => create<T>().Format(src);


        [MethodImpl(Inline)]
        public static string format<T>(T src, BitFormatConfig config)
            where T : struct
                => create<T>().Format(src, config);

        [MethodImpl(Inline)]
        public static BitFormatter<T> create<T>()
            where T : struct
                => new BitFormatter<T>();

        [MethodImpl(Inline), Op]
        public void Format(byte src, int maxbits, Span<char> dst, ref int k)
        {
            for(var j=0; j<8; j++, k++)
            {                
                if(k>=maxbits)
                    break;

                seek(dst, k) = character(testbit(src, j));
            }
        }

        [MethodImpl(Inline), Op]
        public void Format(in byte src, int length, int maxbits, Span<char> dst)
        {
            var k=0;
            for(var i=0; i<length; i++)
            {
                Format(skip(src,i), maxbits, dst, ref k);
                if(k >= maxbits)
                    break;
            }
        }

        [MethodImpl(Inline)]
        public void Format(ReadOnlySpan<byte> src, int maxbits, Span<char> dst)
            => Format(head(src), src.Length, maxbits, dst);
    }
}