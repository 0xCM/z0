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
    using W = BlobFieldWidth;

    partial class PartRecords
    {
        public static DatasetSink<F,ImgBlobRecord> sink(ImgBlobRecord spec)
        {
            var formatter = Tabular.Formatter<F,W>();
            formatter.EmitHeader();
            return new DatasetSink<F,ImgBlobRecord>(formatter, deposit);
        }

        public static void deposit(in ImgBlobRecord src, IDatasetFormatter<ImgBlobField> dst)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.HeapSize, src.HeapSize);
            dst.Delimit(F.Offset, src.Offset);
            dst.Delimit(F.Value, src.Value);
            dst.EmitEol();            
        }       
    }
}