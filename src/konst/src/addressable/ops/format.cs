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

    partial struct Addressable
    {
        [MethodImpl(Inline), Op]
        public static string format(RelAddress<W32,W16,uint,ushort> src)
            => src.Format();

        [MethodImpl(Inline), Op]
        public static string format(RelAddress<W32,W32,uint,uint> src)
            => src.Format();

        public static string format(in MemoryOffset moffs)
            => text.concat(((ushort)moffs.Offset).FormatAsmHex(), Chars.Space, moffs.Absolute);

        public static void format(in MemoryOffsets offsets, Span<string> dst)        
        {
            var empty = MemoryOffset.Empty;
            for(var k=0u; k<offsets.Count; k++)
            {
                ref readonly var prior = ref (k == 0 ? ref empty : ref offsets[k-1]);
                ref readonly var current = ref offsets[k];
                seek(dst,k) = format(prior, current);                
            }
        }

        public static Span<string> format(in MemoryOffsets offsets)
        {
            var empty = MemoryOffset.Empty;
            var dst = sys.alloc<string>(offsets.Count);
            format(offsets,dst);
            return dst;
        }

        public static string format(in MemoryOffset prior, in MemoryOffset moffs)
        {
            const char Sep = Chars.Space;
            const NumericWidth OffsetWidth = NumericWidth.W16;
            const string BaseIndicator = "@base";
            const string PriorIndicator = "@prior";
            const char Selector = Chars.Plus;

            var offset = moffs.OffsetAddress;
            var offsetFmt = offset.Format(OffsetWidth);
            var moffsBase = text.concat(BaseIndicator, Selector, offsetFmt);
            var priorFmt = text.concat(PriorIndicator, Selector, prior.Absolute.Format(OffsetWidth));

            if(prior.IsEmpty)
                return text.concat(offsetFmt, Sep, moffs.Absolute, Sep, moffsBase, Sep, priorFmt);
            
            var delta = moffs.Absolute - prior.Absolute;
            var deltaFmt = delta.Format(OffsetWidth);
            var moffsPrior = text.concat(PriorIndicator, Selector, deltaFmt);
            
            return text.concat(offsetFmt, Sep, moffs.Absolute, Sep, moffsBase, Sep, moffsPrior);
        }
    }
}