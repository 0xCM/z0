//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Channels
    {
        [MethodImpl(Inline), Op]
        public static Channel<N1,W8> channel(N1 n, W8 w)
            => flows.channel(n,w8);
        
        [MethodImpl(Inline), Op]
        public static Channel<N2,W8> channel(N2 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N3,W8> channel(N3 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N4,W8> channel(N4 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N5,W8> channel(N5 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N6,W8> channel(N6 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N7,W8> channel(N7 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N8,W8> channel(N8 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N1,W16> channel(N1 n, W16 w)
            => flows.channel(n,w16);
        
        [MethodImpl(Inline), Op]
        public static Channel<N2,W16> channel(N2 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N3,W16> channel(N3 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N4,W16> channel(N4 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N5,W16> channel(N5 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N6,W16> channel(N6 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N7,W16> channel(N7 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N16,W8> channel(N16 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N32,W8> channel(N32 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N64,W8> channel(N64 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N128,W8> channel(N128 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N256,W8> channel(N256 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N512,W8> channel(N512 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N1024,W8> channel(N1024 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N2048,W8> channel(N2048 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N4096,W8> channel(N4096 n, W8 w)
            => flows.channel(n,w8);

        [MethodImpl(Inline), Op]
        public static Channel<N8,W16> channel(N8 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N16,W16> channel(N16 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N32,W16> channel(N32 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N64,W16> channel(N64 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N128,W16> channel(N128 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N256,W16> channel(N256 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N512,W16> channel(N512 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N1024,W16> channel(N1024 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N2048,W16> channel(N2048 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N4096,W16> channel(N4096 n, W16 w)
            => flows.channel(n,w16);

        [MethodImpl(Inline), Op]
        public static Channel<N8,W32> channel(N8 n, W32 w)
            => flows.channel(n,w32);

        [MethodImpl(Inline), Op]
        public static Channel<N16,W32> channel(N16 n, W32 w)
            => flows.channel(n,w32);

        [MethodImpl(Inline), Op]
        public static Channel<N32,W32> channel(N32 n, W32 w)
            => flows.channel(n,w32);

        [MethodImpl(Inline), Op]
        public static Channel<N64,W32> channel(N64 n, W32 w)
            => flows.channel(n,w32);

        [MethodImpl(Inline), Op]
        public static Channel<N128,W32> channel(N128 n, W32 w)
            => flows.channel(n,w32);

        [MethodImpl(Inline), Op]
        public static Channel<N256,W32> channel(N256 n, W32 w)
            => flows.channel(n,w32);

        [MethodImpl(Inline), Op]
        public static Channel<N512,W32> channel(N512 n, W32 w)
            => flows.channel(n,w32);

        [MethodImpl(Inline), Op]
        public static Channel<N1024,W32> channel(N1024 n, W32 w)
            => flows.channel(n,w32);

        [MethodImpl(Inline), Op]
        public static Channel<N2048,W32> channel(N2048 n, W32 w)
            => flows.channel(n,w32);

        [MethodImpl(Inline), Op]
        public static Channel<N4096,W32> channel(N4096 n, W32 w)
            => flows.channel(n,w32);

        [MethodImpl(Inline), Op]
        public static Channel<N8,W64> channel(N8 n, W64 w)
            => flows.channel(n,w64);

        [MethodImpl(Inline), Op]
        public static Channel<N16,W64> channel(N16 n, W64 w)
            => flows.channel(n,w64);

        [MethodImpl(Inline), Op]
        public static Channel<N32,W64> channel(N32 n, W64 w)
            => flows.channel(n,w64);

        [MethodImpl(Inline), Op]
        public static Channel<N64,W64> channel(N64 n, W64 w)
            => flows.channel(n,w64);

        [MethodImpl(Inline), Op]
        public static Channel<N128,W64> channel(N128 n, W64 w)
            => flows.channel(n,w64);

        [MethodImpl(Inline), Op]
        public static Channel<N256,W64> channel(N256 n, W64 w)
            => flows.channel(n,w64);

        [MethodImpl(Inline), Op]
        public static Channel<N512,W64> channel(N512 n, W64 w)
            => flows.channel(n,w64);

        [MethodImpl(Inline), Op]
        public static Channel<N1024,W64> channel(N1024 n, W64 w)
            => flows.channel(n,w64);

        [MethodImpl(Inline), Op]
        public static Channel<N2048,W64> channel(N2048 n, W64 w)
            => flows.channel(n,w64);

        [MethodImpl(Inline), Op]
        public static Channel<N4096,W64> channel(N4096 n, W64 w)
            => flows.channel(n,w64);
    }
}