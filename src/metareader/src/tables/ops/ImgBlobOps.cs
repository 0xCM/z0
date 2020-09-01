//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = ImgBlobField;
    using W = ImageBlobFieldWidth;

    partial class PartRecords
    {
        public static DataSink<F,ImgBlobRecord> sink(ImgBlobRecord spec)
        {
            var formatter = Formatters.record<F,W>();
            formatter.EmitHeader();
            return new DataSink<F,ImgBlobRecord>(formatter, deposit);
        }

        public static void deposit(in ImgBlobRecord src, IDatasetFormatter<ImgBlobField> dst)
        {
            dst.Delimit(F.Sequence, src.Seq);
            dst.Delimit(F.HeapSize, src.HeapSize);
            dst.Delimit(F.Offset, src.Offset);
            dst.Delimit(F.Value, src.Data);
            dst.EmitEol();
        }
    }
}