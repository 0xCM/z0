//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = ImgStringField;
    using W = StringValueWidths;

    partial class PartRecords
    {
        public static RecordFormatter<F,W> formatter(ImgStringRecord spec)
            => Tabular.Formatter<F,W>();

        [Op]
        public static ref readonly RecordFormatter<F,W> format(in ImgStringRecord src, in RecordFormatter<F,W> dst, bool eol = true)
        {            
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Source, src.Source);
            dst.Delimit(F.HeapSize, src.HeapSize);
            dst.Delimit(F.Length, src.Length);
            dst.Delimit(F.Offset, src.Offset);
            dst.Delimit(F.Value, src.Value);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }
    }
}