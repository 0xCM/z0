//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct BitFormatter : IBitFormatter
    {
        public static BitFormatter Service => default;

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitFormatter<T> create<T>()
            where T : struct
                => default; //BitFormatter.create<T>();

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
                return create<byte>().Format((byte)z.rebox(src, NumericKind.U8));
            else if(type == TypeCode.UInt16 || type == TypeCode.Int16)
                return create<ushort>().Format((ushort)z.rebox(src, NumericKind.U16));
            else if(type == TypeCode.UInt32  || type == TypeCode.Int32 || type == TypeCode.Single)
                return create<uint>().Format((uint)z.rebox(src, NumericKind.U32));
            else if(type == TypeCode.UInt64 || type == TypeCode.Int64 || type == TypeCode.Double)
                return create<ulong>().Format((ulong)z.rebox(src, NumericKind.U64));
            else
                return EmptyString;
        }
        
        public static ReadOnlySpan<char> chars(byte[] src)
        {   
            var dst = span<char>(src.Length*8);
            var input = span(src);
            var config = BitFormatConfig.Default;
            Service.Format(src, dst.Length, dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public void Format(byte src, int maxbits, Span<char> dst, ref int k)
        {
            for(var j=0; j<8; j++, k++)
            {                
                if(k>=maxbits)
                    break;
                z.seek(dst, (uint)k) = z.@char(z.@bool(z.testbit(src, j)));
            }
        }

        [MethodImpl(Inline), Op]
        public void Format(in byte src, int length, int maxbits, Span<char> dst)
        {
            var k=0;
            for(var i=0u; i<length; i++)
            {
                Format(z.skip(src,i), maxbits, dst, ref k);
                if(k >= maxbits)
                    break;
            }
        }

        [MethodImpl(Inline)]
        public void Format(ReadOnlySpan<byte> src, int maxbits, Span<char> dst)
            => Format(first(src), src.Length, maxbits, dst);
    }    
}