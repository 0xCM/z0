//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;
    using static vfunc;

    [ApiHost(ApiHostKind.Generic)]
    public static partial class vblocks
    {


    }

    partial class vblocks
    {
        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers & (~NumericKind.U64))]
        public static ref readonly Block128<T> vmax<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VF.vmax<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers & (~NumericKind.U64))]
        public static ref readonly Block256<T> vmax<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VF.vmax<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers & (~NumericKind.U64))]
        public static ref readonly Block128<T> vmin<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VF.vmin<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers & (~NumericKind.U64))]
        public static ref readonly Block256<T> vmin<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VF.vmin<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> veq<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VF.veq<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> veq<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VF.veq<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers & (~NumericKind.U64))]
        public static ref readonly Block128<T> vlt<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VF.vlt<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers& (~NumericKind.U64))]
        public static ref readonly Block256<T> vlt<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VF.vlt<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers & (~NumericKind.U64))]
        public static ref readonly Block128<T> vgt<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VF.vgt<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers& (~NumericKind.U64))]
        public static ref readonly Block256<T> vgt<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VF.vgt<T>(n256));


        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> vnonz<T>(in Block128<T> a, Span<bit> dst)
            where T : unmanaged
        {
            var f = VF.vnonz<T>(n128);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> vnonz<T>(in Block256<T> a, Span<bit> dst)
            where T : unmanaged
        {
            var f = VF.vnonz<T>(n256);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> vtestc<T>(in Block128<T> a, in Block128<T> b, Span<bit> dst)
            where T : unmanaged
        {            

            var f = VF.vtestc<T>(n128);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> vtestc<T>(in Block256<T> a, in Block256<T> b, Span<bit> dst)
            where T : unmanaged
        {
            var f = VF.vtestc<T>(n256);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> vtestz<T>(in Block128<T> a, in Block128<T> b, Span<bit> dst)
            where T : unmanaged
        {
            var f = VF.vtestz<T>(n128);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> vtestz<T>(in Block256<T> a, in Block256<T> b, Span<bit> dst)
            where T : unmanaged
        {
            var f = VF.vtestz<T>(n256);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }
    }
}