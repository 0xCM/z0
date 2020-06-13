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
    using static Typed;
    using static SymBits;

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci2 src)
        {
            var storage = 0u;
            ref var dst = ref Unsafe.As<uint,char>(ref storage);
            seek(ref dst, 0) = (char)(byte)(src.Storage >> 0);
            seek(ref dst, 1) = (char)(byte)(src.Storage >> 8);
            return Spans.cover(dst, 2);
            // var dst = CharBlocks.c16s(CharBlocks.alloc(n2));
            // decode(src,dst);
            // return dst;
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

            return Spans.cover(dst, 2);

            // var dst = CharBlocks.c16s(CharBlocks.alloc(n4));
            // decode(src,dst);
            // return dst;
        }

        // [MethodImpl(Inline), Op]
        // public static ReadOnlySpan<char> decode(in asci8 src)
        // {
        //     var dst = CharBlocks.c16s(CharBlocks.alloc(n8));
        //     decode(src,dst);
        //     return dst;
        // }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci8 src)
        {
            var decoded = SymBits.vinflate(vbytes(w128, src.Storage));
            return cast<char>(bytespan(vlo(decoded)));
            
            // var dst = CharBlocks.c16s(CharBlocks.alloc(n8));
            // decode(src,dst);
            // return dst;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci16 src)
            => cast<char>(bytespan(SymBits.vinflate(src.Storage)));

        // [MethodImpl(Inline), Op]
        // public static ReadOnlySpan<char> decode(in asci16 src)
        // {
        //     var data = SymBits.vinflate(src.Storage);
        //     var bytes = bytespan(data);
        //     var chars = cast<char>(bytes);    
        //     var len = chars.Length;
        //     for(var i=0; i<len; i++)
        //     {
        //         if((AsciCharCode)skip(chars,i) == AsciCharCode.Null)
        //         {
        //             len = i;
        //             break;
        //         }
        //     }

        //     return chars.Slice(0, len);
        // }

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

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci32 src)
        {            
            var lo = SymBits.vinflate(src.Storage, n0);
            var hi = SymBits.vinflate(src.Storage, n1);
            var data = bytespan(new Seg512(lo,hi));            
            return cast<char>(data);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in asci64 src)
        {            
            var x = src.Storage;
            var x0 = SymBits.vinflate(x.Lo,n0);
            var x1 = SymBits.vinflate(x.Lo,n1);
            var x2 = SymBits.vinflate(x.Hi,n0);
            var x3 = SymBits.vinflate(x.Hi,n1);
            var data = new Seg1024(x0,x1,x2,x3);
            return cast<char>(Control.bytespan(data));
        }
    }
}