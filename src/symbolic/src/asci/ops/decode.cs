//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Root;
    using static SymBits;
    using static Typed;

    partial struct asci
    {
        [MethodImpl(Inline)]
        public static void decode(ReadOnlySpan<byte> src, Span<char> dst)
        {            
            var count = length(src,dst);
            for(var i=0; i<count; i++)            
                seek(dst,i) = @char(skip(src,i));
        }
                
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci2 src)
        {
            var storage = 0u;
            ref var dst = ref Unsafe.As<uint,char>(ref storage);
            seek(ref dst, 0) = (char)(byte)(src.Storage >> 0);
            seek(ref dst, 1) = (char)(byte)(src.Storage >> 8);
            return Imagine.cover(dst, 2);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci4 src)
        {
            var storage = 0ul;
            ref var dst = ref Unsafe.As<ulong,char>(ref storage);
            seek(ref dst, 0) = (char)(byte)(src.Storage >> 0);
            seek(ref dst, 1) = (char)(byte)(src.Storage >> 8);
            seek(ref dst, 2) = (char)(byte)(src.Storage >> 16);
            seek(ref dst, 3) = (char)(byte)(src.Storage >> 24);
            return Imagine.cover(dst, asci4.Size);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci8 src)
        {
            var decoded = vinflate(vbytes(w128, src.Storage));
            return Root.cast<char>(bytespan(vlo(decoded)));            
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci16 src)
            => Root.cast<char>(bytespan(vinflate(src.Storage)));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci32 src)
        {            
            var lo = vinflate(src.Storage, n0);
            var hi = vinflate(src.Storage, n1);
            var data = bytespan(new Seg512(lo,hi));            
            return Root.cast<char>(data);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci64 src)
        {            
            var x = src.Storage;
            var x0 = vinflate(x.Lo,n0);
            var x1 = vinflate(x.Lo,n1);
            var x2 = vinflate(x.Hi,n0);
            var x3 = vinflate(x.Hi,n1);
            var data = new Seg1024(x0,x1,x2,x3);
            return Root.cast<char>(bytespan(data));
        }

        [MethodImpl(Inline), Op]
        public static int decode(in asci2 src, Span<char> dst)
        {
            var data = asci.cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            return 2;
        } 

        [MethodImpl(Inline), Op]
        public static int decode(in asci4 src, Span<char> dst)
        {
            var data = asci.cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
            return 4;
        } 

        [MethodImpl(Inline), Op]
        public static int decode(in asci5 src, Span<char> dst)
        {
            var data = asci.cover(src);
            seek(dst,0) = skip(data,0);
            seek(dst,1) = skip(data,1);
            seek(dst,2) = skip(data,2);
            seek(dst,3) = skip(data,3);
            seek(dst,4) = skip(data,4);
            return 5;
        } 

        [MethodImpl(Inline), Op]
        public static int decode(in asci8 src, Span<char> dst)
        {
            var data = asci.cover(src);
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
        public static int decode(in asci16 src, Span<char> dst)
            => decode(SymBits.vinflate(src.Storage), ref head(dst));

        [MethodImpl(Inline), Op]
        public static int decode(in asci32 src, Span<char> dst)
        {
            ref var c = ref head(dst);
            var count = decode(SymBits.vinflate(vlo(src.Storage)), ref c);
            count += decode(SymBits.vinflate(vhi(src.Storage)), ref add(ref c, count));
            return count;
        }

        [MethodImpl(Inline)]
        static int decode(Vector256<ushort> data, ref char dst)
        {
            var bytes = bytespan(data);
            var chars = Root.cast<char>(bytes);
            var count = 0;    
            for(var i=0; i<chars.Length; i++, count++)
            {
                ref readonly var c = ref skip(chars,i);
                if((AsciCharCode)c != AsciCharCode.Null)
                    seek(ref dst,i) = c;
                else
                    break;
            }
            return count;
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

        readonly struct Seg1024
        {
            readonly Vector256<ushort> X0;

            readonly Vector256<ushort> X1;

            readonly Vector256<ushort> X2;

            readonly Vector256<ushort> X3;

            [MethodImpl(Inline), Op]
            public Seg1024(Vector256<ushort> x0, Vector256<ushort> x1,Vector256<ushort> x2,Vector256<ushort> x3)
            {
                X0 = x0;
                X1 = x1;
                X2 = x2;
                X3 = x3;
            }
        }
    }
}