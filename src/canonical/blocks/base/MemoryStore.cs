//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Control;

    [ApiHost]
    public readonly struct MemoryStore : IApiHost<MemoryStore>
    {        
        static MemoryBlocks Blocks => MemoryBlocks.Service;

        public static MemoryStore Service => default;
                

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(in MemoryRef src)
            => src.Load();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> load<T>(in MemoryRef src)
            where T : struct
                => src.Load<T>();

        [MethodImpl(Inline), Op]
        public MemoryBlock block(in MemoryRef src)
            => Blocks.block(src);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public MemoryBlock<T> block<T>(in MemoryRef src)
            where T : struct
                => Blocks.block<T>(src);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(in MemoryBlock src, int i)
            => ref Blocks.cell(src,i);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> cells(in MemoryBlock src)
            => Blocks.load(src);
            
        [MethodImpl(Inline), Op]
        public ulong address(in MemoryRef n, int i, byte scale, ushort offset)
            => ((ulong)scale)*skip(n.Load(),i) + (ulong)offset;

        [MethodImpl(Inline), Op]
        public ulong address(in MemoryBlock block, int i, byte scale, ushort offset)
            => ((ulong)scale)*skip(Blocks.load(block), i) + (ulong)offset;
    }
}