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
    using static PartRecords;

    partial class XTend
    {
        public static void Deposit(this BlobRecord src, IDatasetFormatter<BlobField> dst)
        {
            dst.Delimit(BlobField.Sequence, src.Sequence);
            dst.Delimit(BlobField.HeapSize, src.HeapSize);
            dst.Delimit(BlobField.Offset, src.Offset);
            dst.Delimit(BlobField.Value, src.Value);
            dst.EmitEol();            
        }

        public static DatasetSink<BlobField,BlobRecord> Sink(this IWfPartEmission wf, BlobField f = default)
            => PartRecords.sink(wf.DataTypes.Blobs);
    }
}