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

    partial class vblocks
    {
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block128<T> vmax<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vmax<T>(n128));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block256<T> vmax<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vmax<T>(n256));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block128<T> vmin<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vmin<T>(n128));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block256<T> vmin<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vmin<T>(n256));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block128<T> veq<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.veq<T>(n128));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block256<T> veq<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.veq<T>(n256));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block128<T> vlt<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vlt<T>(n128));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block256<T> vlt<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vlt<T>(n256));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block128<T> vgt<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vgt<T>(n128));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block256<T> vgt<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vgt<T>(n256));


        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Span<bit> vnonz<T>(in Block128<T> a, Span<bit> dst)
            where T : unmanaged
        {
            var f = VX.vnonz<T>(n128);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Span<bit> vnonz<T>(in Block256<T> a, Span<bit> dst)
            where T : unmanaged
        {
            var f = VX.vnonz<T>(n256);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Span<bit> vtestc<T>(in Block128<T> a, in Block128<T> b, Span<bit> dst)
            where T : unmanaged
        {
            var f = VX.vtestc<T>(n128);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Span<bit> vtestc<T>(in Block256<T> a, in Block256<T> b, Span<bit> dst)
            where T : unmanaged
        {
            var f = VX.vtestc<T>(n256);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Span<bit> vtestz<T>(in Block128<T> a, in Block128<T> b, Span<bit> dst)
            where T : unmanaged
        {
            var f = VX.vtestz<T>(n128);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Span<bit> vtestz<T>(in Block256<T> a, in Block256<T> b, Span<bit> dst)
            where T : unmanaged
        {
            var f = VX.vtestz<T>(n256);
            var blocks = a.BlockCount;            
            ref var result = ref head(dst);
            for(var block = 0; block < blocks; block++)
                seek(ref result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }
    }

}