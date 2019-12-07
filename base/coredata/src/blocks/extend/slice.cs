//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static DataBlocks;

    partial class BlockExtend    
    {
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this Block16<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this Block16<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this Block32<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this Block32<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this Block64<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this Block64<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this Block128<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this Block128<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this Block256<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this Block256<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);             

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> Slice<T>(this ConstBlock16<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> Slice<T>(this ConstBlock16<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> Slice<T>(this ConstBlock32<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> Slice<T>(this ConstBlock32<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> Slice<T>(this ConstBlock64<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> Slice<T>(this ConstBlock64<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> Slice<T>(this ConstBlock128<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> Slice<T>(this ConstBlock128<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> Slice<T>(this ConstBlock256<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> Slice<T>(this ConstBlock256<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);             


        [MethodImpl(Inline)]
        public static Span<T> Slice<N,T>(this NatBlock<N,T> src, int offset)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.Slice(offset);

        [MethodImpl(Inline)]
        public static Span<T> Slice<N,T>(this NatBlock<N,T> src, int offset, int length)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.Slice(offset, length);

    }

}