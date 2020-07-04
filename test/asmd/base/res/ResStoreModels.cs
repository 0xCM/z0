//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    using static Root;
    using static Typed;
    
    [ApiHost]
    public unsafe readonly struct ResStoreModels 
    {
        public static ResStoreModels Service => default;    

        internal static ResStoreModel Data 
            => ResStoreModel.Data;
        
        public MemRef[] Refs 
        {
            [MethodImpl(Inline)]
            get => Data.provided();
        }
        
        [MethodImpl(Inline), Op]
        public MemStore store()
            => MemStore.Create(Refs);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> leads()
            => Data.leads();

        [Op]
        public ReadOnlySpan<MemoryAddress> locations(in MemStore store)
        {
            var sources = store.Sources;
            var results = Spans.alloc<MemoryAddress>(sources.Length);
            locations(store,results);
            return results;
        }
        
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
        public MemRef memref(byte n)
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

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> span<N>(N n)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N0))
                return ResStoreModel.Seg00;
            else if(typeof(N) == typeof(N1))
                return ResStoreModel.Seg01;
            else if(typeof(N) == typeof(N2))
                return ResStoreModel.Seg02;
            else if(typeof(N) == typeof(N3))
                return ResStoreModel.Seg03;
            else if(typeof(N) == typeof(N4))
                return ResStoreModel.Seg04;
            else if(typeof(N) == typeof(N5))
                return ResStoreModel.Seg05;
            else if(typeof(N) == typeof(N6))
                return ResStoreModel.Seg06;
            else if(typeof(N) == typeof(N7))
                return ResStoreModel.Seg07;
            else
                return Data.SegZ;
        }

        [MethodImpl(Inline)]
        public ref readonly byte first<N>(N n)
            where N : unmanaged, ITypeNat
                => ref head(span(n));        

        [MethodImpl(Inline)]
        public ref readonly byte cell<N>(N n, int i)
            where N : unmanaged, ITypeNat
                => ref skip(span(n),i);    

        [MethodImpl(Inline)]
        public unsafe MemRef memref<N>(N n = default)
            where N : unmanaged, ITypeNat
        {                
            var src = span<N>(n); 
            var pSrc = Root.constptr(head(src));
            return new MemRef(pSrc, src.Length);
        }

        [Op]
        static void locations(in MemStore store, Span<MemoryAddress> results)
        {
            var sources = store.Sources;
            for(var i=0; i<sources.Length; i++)
            {
                ref readonly var source = ref skip(sources,i);
                var length = source.DataSize;
                var data = MemStores.Service.load(source);                                
                
                if(data.Length == length)
                {
                    for(var j = 0; j<length; j++)
                    {
                        ref readonly var x = ref skip(data,j);
                        if(j == 0)
                        {
                            var a = Addressable.address(x);
                            if(source.Address == a)
                                seek(results,i) = a;
                        }
                    }
                }
            }
        }
    }
}