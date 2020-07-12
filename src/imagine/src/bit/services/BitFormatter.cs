//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Root;
    using static As;
    
    [ApiHost]
    public readonly struct BitFormatter : IApiHost<BitFormatter>, IBitFormatter
    {
        public static BitFormatter Service => default;

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitFormatter<T> create<T>()
            where T : struct
                => default;

        [MethodImpl(Inline)]
        public static string format<T>(T src)
            where T : struct
                => create<T>().Format(src);

        [MethodImpl(Inline)]
        public static string format<T>(T src, in BitFormatConfig config)
            where T : struct
                => create<T>().Format(src, config);

        [MethodImpl(Inline)]
        public static BitFormatConfig configure(bool tlz = false)
            => configure(tlz:tlz, specifier:false, blockWidth:null, blocksep:null, rowWidth:null, maxbits:null,zpad:null);

        [MethodImpl(Inline)]
        public static BitFormatConfig limited(int maxbits, int? zpad = null)
            => configure(tlz:true, maxbits: maxbits, zpad:zpad);

        [MethodImpl(Inline)]
        public static BitFormatConfig blocked(int width, char? sep = null, int? maxbits = null, bool specifier = false)
            => configure(tlz:false, blockWidth: width, blocksep: sep, maxbits:maxbits, specifier: specifier);

        [MethodImpl(Inline)]
        public static BitFormatConfig rows(int blockWidth, int rowWidth, char? blockSep = null)
            => configure(tlz:false, blockWidth: blockWidth, rowWidth:rowWidth, blocksep: blockSep);

        [MethodImpl(Inline)]
        public static BitFormatConfig configure(bool tlz, bool specifier = false, int? blockWidth = null, 
            char? blocksep = null, int? rowWidth = null, int? maxbits = null, int? zpad = null)
                => new BitFormatConfig(tlz, specifier, blockWidth, blocksep, rowWidth, maxbits,zpad);

        public static string format(object src, TypeCode type)
        {
            if(type == TypeCode.Byte || type == TypeCode.SByte)
                return Formatters.bits<byte>().Format((byte)rebox(src, NumericKind.U8));
            else if(type == TypeCode.UInt16 || type == TypeCode.Int16)
                return Formatters.bits<ushort>().Format((ushort)rebox(src, NumericKind.U16));
            else if(type == TypeCode.UInt32  || type == TypeCode.Int32 || type == TypeCode.Single)
                return Formatters.bits<uint>().Format((uint)rebox(src, NumericKind.U32));
            else if(type == TypeCode.UInt64 || type == TypeCode.Int64 || type == TypeCode.Double)
                return Formatters.bits<ulong>().Format((ulong)rebox(src, NumericKind.U64));
            else
                return string.Empty;
        }



        [MethodImpl(Inline), Op]
        public void Format(byte src, int maxbits, Span<char> dst, ref int k)
        {
            for(var j=0; j<8; j++, k++)
            {                
                if(k>=maxbits)
                    break;
                seek(dst, k) = @char(@bool(testbit(src, j)));
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