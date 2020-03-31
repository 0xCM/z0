//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Core;
    using static SBlock;

    partial class gblocks
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers & (~NumericKind.U64))]
        public static ref readonly Block128<T> max<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vmax<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers & (~NumericKind.U64))]
        public static ref readonly Block256<T> max<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vmax<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers & (~NumericKind.U64))]
        public static ref readonly Block128<T> min<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vmin<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers & (~NumericKind.U64))]
        public static ref readonly Block256<T> min<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vmin<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> eq<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.veq<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> eq<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.veq<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers & (~NumericKind.U64))]
        public static ref readonly Block128<T> lt<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vlt<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers& (~NumericKind.U64))]
        public static ref readonly Block256<T> lt<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vlt<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers & (~NumericKind.U64))]
        public static ref readonly Block128<T> gt<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vgt<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers& (~NumericKind.U64))]
        public static ref readonly Block256<T> gt<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vgt<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Span<bit> nonz<T>(in Block128<T> a, Span<bit> dst)
            where T : unmanaged
        {
            var f = VSvc.vnonz<T>(n128);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Span<bit> nonz<T>(in Block256<T> a, Span<bit> dst)
            where T : unmanaged
        {
            var f = VSvc.vnonz<T>(n256);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Span<bit> testc<T>(in Block128<T> a, in Block128<T> b, Span<bit> dst)
            where T : unmanaged
        {            

            var f = VSvc.vtestc<T>(n128);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Span<bit> testc<T>(in Block256<T> a, in Block256<T> b, Span<bit> dst)
            where T : unmanaged
        {
            var f = VSvc.vtestc<T>(n256);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Span<bit> testz<T>(in Block128<T> a, in Block128<T> b, Span<bit> dst)
            where T : unmanaged
        {
            var f = VSvc.vtestz<T>(n128);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Span<bit> testz<T>(in Block256<T> a, in Block256<T> b, Span<bit> dst)
            where T : unmanaged
        {
            var f = VSvc.vtestz<T>(n256);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }
    }
}