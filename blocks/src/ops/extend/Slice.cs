//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XBlocks    
    {
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block16<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block16<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block32<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block32<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block64<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block64<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block128<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block128<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);            

        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block256<T> src, int offset)
            where T : unmanaged
                => src.Data.Slice(offset);
            
        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block256<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);             

        [MethodImpl(Inline)]
        public static Span<T> Slice<T>(this in Block512<T> src, int offset, int length)
            where T : unmanaged
                => src.Data.Slice(offset,length);
    }
}