//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    [ApiHost]
    public readonly struct StoreServices : IApiHost<StoreServices>
    {        
        public static StoreServices Service => default;

        internal static Store Data => Store.Storage;
        
        static SpanReader Reader => SpanReader.Service;
        
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> span(int n)
        {
            if(n == 0)
                return span8(n0);
            else if(n == 1)
                return span8(n1);
            else if(n == 2)
                return span8(n2);
            else if(n == 3)
                return span8(n3);
            else
                return span8(n256);
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> span8<N>(N n)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N0))
                return Data.W8x64x00;
            else if(typeof(N) == typeof(N1))
                return Data.W8x64x01;
            else if(typeof(N) == typeof(N2))
                return Data.W8x64x02;
            else if(typeof(N) == typeof(N3))
                return Data.W8x64x03;
            else
                return Data.W8x0;
        }

        [MethodImpl(Inline), Op]
        public MemoryRef @ref(int n)
        {
            if(n == 0)
                return @ref(n0);
            else if(n == 1)
                return @ref(n1);
            else if(n == 2)
                return @ref(n2);
            else if(n == 3)
                return @ref(n3);
            else
                return @ref(n256);
        }

        [MethodImpl(Inline)]
        public unsafe MemoryRef @ref<N>(N n = default)
            where N : unmanaged, ITypeNat
        {                
            var src = span8<N>(n); 
            var pSrc = constptr(head(src));
            return new MemoryRef(pSrc, src.Length);
        }

        [MethodImpl(Inline), Op]
        public MemoryBlock block(int n)
            => MemoryBlock.From(@ref(n));

        [MethodImpl(Inline)]
        public MemoryBlock block<N>(N n = default)
            where N : unmanaged, ITypeNat
                => MemoryBlock.From(@ref(n));

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(int n, int i)
            => ref skip(span(n),i);

        [MethodImpl(Inline)]
        public ref readonly byte cell<N>(N n, int i)
            where N : unmanaged, ITypeNat
                => ref skip(span8(n),i);
        
        [MethodImpl(Inline)]
        public ref readonly T cell<W,N,T>(W w, N n, NK<T> t, int i)
            where N : unmanaged, ITypeNat
            where W : unmanaged, ITypeWidth
            where T : unmanaged 
                => ref skip(span(w,n,t),i);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> span<W,N,T>(W w, N n, NK<T> t)
            where N : unmanaged, ITypeNat
            where W : unmanaged, ITypeWidth
            where T : unmanaged 
        {
            if(typeof(W) == typeof(W8))
                return Reader.imagine<T>(span8(n));
            else if(typeof(W) == typeof(W16))
                return Reader.imagine<T>(span16(n));
            else if(typeof(W) == typeof(W32))
                return Reader.imagine<T>(span32(n));
            else if(typeof(W) == typeof(W64))
                return Reader.imagine<T>(span64(n));
            else
                return ReadOnlySpan<T>.Empty;
        }

        [MethodImpl(Inline)]
        ReadOnlySpan<ushort> span16<N>(N n)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N0))
                return Data.W16x32x00;
            else if(typeof(N) == typeof(N1))
                return Data.W16x32x01;
            else
                return Data.W16x0;
        }

        [MethodImpl(Inline)]
        ReadOnlySpan<uint> span32<N>(N n)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N0))
                return Data.W32x64x00;
            else
                return Data.W32x0;
        }

        [MethodImpl(Inline)]
        ReadOnlySpan<ulong> span64<N>(N n)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N0))
                return Data.W64x32x00;
            else
                return Data.W64x0;
        }
    }    
}