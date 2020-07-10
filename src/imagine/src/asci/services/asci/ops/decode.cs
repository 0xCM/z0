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
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(AsciCharCode src)
        {
            var storage = 0u;
            ref var dst = ref As.@as<uint,char>(ref storage);
            seek(ref dst, 0) = (char)(byte)src;
            return As.cover(dst, 2);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci2 src)
        {
            var storage = 0u;
            ref var dst = ref As.@as<uint,char>(ref storage);
            seek(ref dst, 0) = (char)(byte)(src.Storage >> 0);
            seek(ref dst, 1) = (char)(byte)(src.Storage >> 8);
            return As.cover(dst, 2);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci4 src)
        {
            var storage = 0ul;
            ref var dst = ref As.@as<ulong,char>(ref storage);
            seek(ref dst, 0) = (char)(byte)(src.Storage >> 0);
            seek(ref dst, 1) = (char)(byte)(src.Storage >> 8);
            seek(ref dst, 2) = (char)(byte)(src.Storage >> 16);
            seek(ref dst, 3) = (char)(byte)(src.Storage >> 24);
            return As.cover(dst, asci4.Size);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci8 src)
        {
            var decoded = vinflate(vbytes(w128, src.Storage));
            return z.recover<char>(As.bytes(vlo(decoded)));            
        }


        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci16 src)
            => z.recover<char>(As.bytes(vinflate(src.Storage)));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci32 src)
        {            
            var lo = vinflate(src.Storage, n0);
            var hi = vinflate(src.Storage, n1);
            return z.recover<char>(As.bytes(new Seg512(lo,hi)));
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci64 src)
        {            
            var x = src.Storage;
            var x0 = vinflate(x.Lo,n0);
            var x1 = vinflate(x.Lo,n1);
            var x2 = vinflate(x.Hi,n0);
            var x3 = vinflate(x.Hi,n1);
            return z.recover<char>(As.bytes(new Seg1024(x0,x1,x2,x3)));
        }

        [MethodImpl(Inline), Op]
        public static void decode(in asci8 src, ref char dst)
        {
            var decoded = vinflate(vbytes(w128, src.Storage));
            SymBits.vstore(decoded.GetLower(), ref As.@as<char,ushort>(ref dst));
        }

        [MethodImpl(Inline), Op]
        public static void decode(in asci16 src, ref char dst)
        {
           var decoded = vinflate(src.Storage);
           SymBits.vstore(decoded, ref As.@as<char,ushort>(ref dst));
        }

        [MethodImpl(Inline), Op]
        public static void decode(in asci32 src, ref char dst)
        {
            decode(src.Lo, ref dst);
            decode(src.Hi, ref seek(ref dst, 16));
        }

        [MethodImpl(Inline), Op]
        public static void decode(in asci64 src, ref char dst)
        {
            decode(src.Lo, ref dst);
            decode(src.Hi, ref seek(ref dst, 32));
        }

        [MethodImpl(Inline)]
        static int decode(Vector256<ushort> data, ref char dst)
        {
            var bytes = bytespan(data);
            var chars = z.recover<char>(bytes);
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