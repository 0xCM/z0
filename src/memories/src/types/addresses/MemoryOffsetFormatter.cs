//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct AddressFormatter
    {        
        public static string Format(in MemoryOffset moffs)
        {
            var w = moffs.OffsetWidth;
            var offset = ((ushort)moffs.Offset).FormatAsmHex();
            var dst = text.concat(offset, Chars.Space, moffs.Absolute);
            return dst;
        }

        public static void Format(in MemoryOffsets offsets)
        {
            var empty = MemoryOffset.Empty;
            for(var k=0; k<offsets.Count; k++)
            {
                ref readonly var prior = ref (k == 0 ? ref empty : ref offsets[k-1]);
                ref readonly var current = ref offsets[k];
                term.print(Format(prior, current));
            }
        }

        public static string Format(in MemoryOffset prior, in MemoryOffset moffs)
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