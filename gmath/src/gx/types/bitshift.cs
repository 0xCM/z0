//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    partial class GXTypes
    {
        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct Srl<T> : IShiftOp<T>, IUnarySpanOpImm8<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {
            public const string Name = "srl";

            public static Srl<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, byte offset) => gmath.srl(a, offset);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, byte count, Span<T> dst)
            {            
                var len = dst.Length;
                ref readonly var input = ref head(src);
                ref var target = ref head(dst);
                for(var i = 0; i<len; i++) 
                    seek(ref target,i) = gmath.srl(skip(input,i), count);                
                return dst;
            }                

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, ReadOnlySpan<T> counts, Span<T> dst)
            {
                var len = dst.Length;
                ref readonly var input = ref head(src);
                ref readonly var count = ref head(counts);
                ref var target = ref head(dst);
                for(var i=0; i < len; i++)
                    seek(ref target,i) = gmath.srl(skip(input,i), convert<T,byte>(skip(count,i)));
                return dst;
            }
        }

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct Sll<T> : IShiftOp<T>, IUnarySpanOpImm8<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {
            public const string Name = "sll";

            public static Sll<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, byte offset) => gmath.sll(a, offset);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, byte count, Span<T> dst)
            {            
                var len = dst.Length;
                ref readonly var input = ref head(src);
                ref var target = ref head(dst);
                for(var i = 0; i<len; i++) 
                    seek(ref target,i) = gmath.sll(skip(input,i), count);                
                return dst;
            }                

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, ReadOnlySpan<T> counts, Span<T> dst)
            {
                var len = dst.Length;
                ref readonly var input = ref head(src);
                ref readonly var count = ref head(counts);
                ref var target = ref head(dst);

                for(var i=0; i < len; i++)
                    seek(ref target,i) = gmath.sll(skip(input,i), convert<T,byte>(skip(count,i)));
                return dst;
            }
        }
    }
}