//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static CsPatterns;

    partial struct StringTables
    {
        public static void emit(uint margin, in StringTable src, ITextBuffer dst)
        {
            dst.IndentLine(margin, PublicReadonlyStruct(src.Name));
            dst.IndentLine(margin, Open());
            margin+=4;

            var OffsetsProp = nameof(MemoryStrings.Offsets);
            var DataProp = nameof(MemoryStrings.Data);
            var EntryCountProp = nameof(MemoryStrings.EntryCount);
            var CharCountProp = nameof(MemoryStrings.CharCount);
            var CharBaseProp = nameof(MemoryStrings.CharBase);
            var OffsetBaseProp = nameof(MemoryStrings.OffsetBase);

            dst.IndentLine(margin, Constant(EntryCountProp, src.EntryCount));
            dst.AppendLine();

            dst.IndentLine(margin, Constant(CharCountProp, (uint)src.Content.Length));
            dst.AppendLine();

            dst.IndentLine(margin, StaticLambdaProp(nameof(MemoryAddress), CharBaseProp, "address(Data)"));
            dst.AppendLine();

            dst.IndentLine(margin, StaticLambdaProp(nameof(MemoryAddress), OffsetBaseProp, "address(Offsets)"));
            dst.AppendLine();

            index(margin, src, dst);
            dst.AppendLine();

            dst.IndentLine(margin, SpanRes.bytespan(OffsetsProp, src.OffsetStorage).Format());
            dst.AppendLine();
            dst.IndentLine(margin, SpanRes.charspan(DataProp, src.Content).Format());
            margin-=4;
            dst.IndentLine(margin, Close());
        }
    }
}