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
    public readonly struct MemBlocks : IApiHost<MemBlocks>
    {                
        public static MemBlocks Service => default(MemBlocks);
                        
        [MethodImpl(Inline), Op]
        public MemBlock block(in MemoryRef src)
            => MemBlock.From(src);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public MemBlock<T> block<T>(in MemoryRef src)
            where T : struct
                => MemBlock.From<T>(src);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(in MemBlock src)
            => src.Ref.Load();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> load<T>(in MemBlock src)
            => src.Ref.Load<T>();

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(in MemBlock src, int i)
            => ref Reader.cell(src.Ref.Load(), i);

        [MethodImpl(Inline), Op]
        public ref readonly T cell<T>(in MemBlock src, int i)
            => ref Reader.cell(src.Ref.Load<T>(), i);

        static SpanReader Reader 
            => SpanReader.Service;
    }
}