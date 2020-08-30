//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using F = ImgFieldRecordField;
    using W = FieldRecordFieldWidth;

    partial class PartRecords
    {
        public static RecordFormatter<F,W> formatter(ImgFieldRecord spec)
            => Formatters.record<F,W>();

        public static ref readonly RecordFormatter<F,W> format(in ImgFieldRecord src, in RecordFormatter<F,W> dst, bool eol = true)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Signature, src.Signature);
            dst.Delimit(F.Attributes, src.Attributes);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }
    }
}