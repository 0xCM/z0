//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static Memories;

    using K = ProcessorKinds;

    public class ProcessorModels
    {        
        [MethodImpl(Inline)]
        public static Canonical<S,T> canonical<S,T>(S s = default, T t = default)
            => default;

        [MethodImpl(Inline)]
        public static Numeric<S,T> numeric<S,T>(NK<S> src = default, NK<T> dst = default)
            where S : unmanaged
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static SpanProcessor<S,T> span<S,T>(S src = default, T dst = default)
            => default;

        [MethodImpl(Inline)]
        public static SpanSource<S,T> spansource<S,T>(S src = default, T dst = default)
            => default;

        [MethodImpl(Inline)]
        public static SpanTarget<S,T> spantarget<S,T>(S src = default, T dst = default)
            => default;

        public readonly struct Canonical<S,T>
        {
            public static K.Canonical<S,T> Kind => default;
            
            [MethodImpl(NotInline)]
            public T Process(in S src)
            {
                var srcSize = Unsafe.SizeOf<S>();
                var dstSize = Unsafe.SizeOf<T>();
                var count = math.min(srcSize, dstSize);
                var dst = default(T);
                ref var target = ref Unsafe.As<T,byte>(ref dst);                
                ref readonly var source = ref Unsafe.As<S,byte>(ref edit(src));
                for(var i=0; i<count; i++)
                    seek(ref target,i) = skip(source,i);               
                return dst;
            }
        }

        public readonly struct Numeric<S,T>
            where S : unmanaged
            where T : unmanaged
        {
            public static K.Numeric<S,T> Kind => default;

            [MethodImpl(NotInline)]
            public T Process(S src)
            {
                var srcSize = size<S>();
                var dstSize = size<T>();
                var count = math.min(srcSize, dstSize);
                var dst = default(T);
                var srcBytes = Control.bytes(in src);
                var dstBytes = Control.bytes(in dst);
                for(var i=0; i<count; i++)
                    seek(dstBytes,i) = skip(srcBytes,i);
                return dst;                
            }
        }

        public readonly struct SpanProcessor<S,T>
        {
            public static K.SpanProcessor<S,T> Kind => default;

            public void Process(ReadOnlySpan<S> src, Span<T> dst) 
            {

            }                
        }

        public readonly struct SpanSource<S,T>
        {
            public static K.SpanSource<S,T> Kind => default;

            [MethodImpl(NotInline)]
            public void Process(ReadOnlySpan<S> src, ref T dst) 
            {
                var k = 0;
                var srcCellSize = Unsafe.SizeOf<S>();
                ref var target = ref Unsafe.As<T,byte>(ref dst);                
                for(var i=0; i<src.Length; i++)
                {
                    ref readonly var source = ref Unsafe.As<S,byte>(ref edit(skip(src,i)));
                    for(var j=0; j<srcCellSize; j++)
                        Unsafe.Add(ref target, k++) = skip(source, j);                    
                }
            }                
        }

        public readonly struct SpanTarget<S,T>
        {
            public static K.SpanTarget<S,T> Kind 
                => default;

            public void Process(in S src, Span<T> dst) 
            {

            }                
        }
    }
}