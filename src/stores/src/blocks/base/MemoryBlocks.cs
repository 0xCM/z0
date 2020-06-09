//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    [ApiHost]
    public readonly struct MemoryBlocks : IApiHost<MemoryBlocks>
    {                
        public static MemoryBlocks Service => default(MemoryBlocks);
        
        static SpanReader Reader => SpanReader.Service;
                
        [MethodImpl(Inline), Op]
        public MemoryBlock block(in MemoryRef src)
            => MemoryBlock.From(src);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public MemoryBlock<T> block<T>(in MemoryRef src)
            where T : struct
                => MemoryBlock.From<T>(src);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(in MemoryBlock src)
            => src.Ref.Load();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> load<T>(in MemoryBlock src)
            => src.Ref.Load<T>();

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(in MemoryBlock src, int i)
            => ref Reader.cell(src.Ref.Load(), i);

        [MethodImpl(Inline), Op]
        public ref readonly T cell<T>(in MemoryBlock src, int i)
            => ref Reader.cell(src.Ref.Load<T>(), i);
    }
}