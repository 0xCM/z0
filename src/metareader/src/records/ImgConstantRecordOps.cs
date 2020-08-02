//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Konst;

    using F = ImgConstantField;
    using W = PartRecords.ConstantFieldWidth;

    partial class PartRecords
    {
        public enum ConstantFieldWidth : ushort
        {
            Sequence = 12,

            ParentId = 20,

            Source = 20,

            DataType = 20,

            Value = 30,            
        }

        public static RecordFormatter<F,W> formatter(ImgConstantRecord spec)
            => Tabular.Formatter<F,W>();

        public static ref readonly RecordFormatter<F,W> format(in ImgConstantRecord src, in RecordFormatter<F,W> dst, bool eol = true)
        {            
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.ParentId, src.ParentId);
            dst.Delimit(F.Source, src.Source);
            dst.Delimit(F.DataType, src.DataType);
            dst.Delimit(F.Value, src.Value);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }        
    }
}