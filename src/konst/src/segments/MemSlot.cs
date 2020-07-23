//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    
    [ApiHost]
    public readonly struct MemSlots
    {        
        [MethodImpl(Inline)]
        public static MemSlotView<E> from<E>(Type src)
            where E : unmanaged, Enum
                => new MemSlotView<E>(from(src));

        [MethodImpl(Inline)]
        public static MemSlotView<E> define<E>(params SegRef[] src)
            where E : unmanaged, Enum
                => new MemSlotView<E>(src);

        [MethodImpl(Inline), Op]
        public static MemSlotView from(Type src)
            => FunctionJit.jit(src).Map(m => new SegRef(m.Address, m.Size));

        public static MemSlotView<E> create<E,T>(T src)
            where E : unmanaged, Enum
                => from<E>(typeof(T));

        public static string[] format<E>(MemSlotView<E> src)
            where E : unmanaged, Enum
        {
            var dst = sys.alloc<string>(src.Length);
            format(src,dst);
            return dst;
        }

        public static void format<E>(MemSlotView<E> src, Span<string> dst)
            where E : unmanaged, Enum
        {
            var count = src.Length;            
            ref readonly var lead = ref src.Lookup(default(E));
            for(var i=0u; i<count; i++)
                seek(dst,i) = skip(lead,i).Format();                         
        }

        public static void update<E,T>(ReadOnlySpan<BinaryCode> src, T dst)
            where E : unmanaged, Enum
        {
            var slots = create<E,T>(dst);
            var count = slots.Length;
            ref readonly var lead = ref slots.Lookup(default(E));
            for(var i=0u; i<count; i++)
            {
                ref readonly var code = ref skip(src,i);
                ref readonly var source = ref code[0];
                ref readonly var slot = ref skip(lead, i);
                ref var target = ref slot.Address.Ref<byte>();
                for(var j=0u; j<slot.DataSize; j++)
                    seek(target,j) = skip(source,j);                
            }
        }
    }
}