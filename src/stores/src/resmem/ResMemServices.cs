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
    readonly struct ResMemServices : IApiHost<ResMemServices>
    {        
        public static ResMemServices Service => default;

        internal static ResMemStore Data => ResMemStore.Data;
        
        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> span<N>(N n)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N0))
                return Data.Seg00;
            else if(typeof(N) == typeof(N1))
                return Data.Seg01;
            else if(typeof(N) == typeof(N2))
                return Data.Seg02;
            else if(typeof(N) == typeof(N3))
                return Data.Seg03;
            else if(typeof(N) == typeof(N4))
                return Data.Seg04;
            else if(typeof(N) == typeof(N5))
                return Data.Seg05;
            else if(typeof(N) == typeof(N6))
                return Data.Seg06;
            else if(typeof(N) == typeof(N7))
                return Data.Seg07;
            else
                return Data.SegZ;
        }

        [MethodImpl(Inline)]
        public ref readonly byte cell<N>(N n, int i)
            where N : unmanaged, ITypeNat
                => ref skip(span(n),i);    

        [MethodImpl(Inline)]
        public ref readonly byte first<N>(N n)
            where N : unmanaged, ITypeNat
                => ref head(span(n));        

        [MethodImpl(Inline)]
        public unsafe MemoryRef memref<N>(N n = default)
            where N : unmanaged, ITypeNat
        {                
            var src = span<N>(n); 
            var pSrc = constptr(head(src));
            return new MemoryRef(pSrc, src.Length);
        }

        [MethodImpl(Inline)]
        public MemBlock block<N>(N n = default)
            where N : unmanaged, ITypeNat
                => MemBlock.From(memref(n));

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> span(byte n)
        {
            if(n == 0)
                return span(n0);
            else if(n == 1)
                return span(n1);
            else if(n == 2)
                return span(n2);
            else if(n == 3)
                return span(n3);
            else if(n == 4)
                return span(n4);
            else if(n == 5)
                return span(n5);
            else if(n == 6)
                return span(n6);
            else if(n == 7)
                return span(n7);
            else
                return span(n256);
        }
        
        [MethodImpl(Inline), Op]
        public MemoryRef memref(byte n)
        {
            if(n == 0)
                return memref(n0);
            else if(n == 1)
                return memref(n1);
            else if(n == 2)
                return memref(n2);
            else if(n == 3)
                return memref(n3);
            else if(n == 4)
                return memref(n4);
            else if(n == 5)
                return memref(n5);
            else if(n == 6)
                return memref(n6);
            else if(n == 7)
                return memref(n7);
            else
                return memref(n256);
        }

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(byte n, int i)
        {
            if(n == 0)
                return ref cell(n0,i);
            else if(n == 1)
                return ref cell(n1,i);
            else if(n == 2)
                return ref cell(n2,i);
            else if(n == 3)
                return ref cell(n3,i);
            else if(n == 4)
                return ref cell(n4,i);
            else if(n == 5)
                return ref cell(n5,i);
            else if(n == 6)
                return ref cell(n6,i);
            else if(n == 7)
                return ref cell(n7,i);
            else
                return ref head(Data.SegZ);
        }

        [MethodImpl(Inline), Op]
        public MemBlock block(byte n)
            => MemBlock.From(memref(n));
    }    
}