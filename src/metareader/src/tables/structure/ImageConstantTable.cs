//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    using F = ImageConstantField;
    using W = ImageConstantFieldWidth;

    public enum ImageConstantFieldWidth : ushort
    {
        Sequence = 12,

        ParentId = 20,

        Source = 20,

        DataType = 20,

        Value = 30,
    }

    partial class PartRecords
    {
        public static RecordFormatter<F,W> formatter(ImageConstantRecord src)
            => Formatters.record<F,W>();

        public static ref readonly RecordFormatter<F,W> format(in ImageConstantRecord src, in RecordFormatter<F,W> dst, bool eol = true)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.ParentId, src.ParentId);
            dst.Delimit(F.Source, src.Source);
            dst.Delimit(F.DataType, src.DataType);
            dst.Delimit(F.Value, src.Content);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }
    }
}