//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using F = ImageFieldTableField;
    using W = ImageFieldTabledWidth;

    partial class PartRecords
    {
        public static RecordFormatter<F,W> formatter(ImageFieldTable spec)
            => Formatters.record<F,W>();

        public static ref readonly RecordFormatter<F,W> format(in ImageFieldTable src, in RecordFormatter<F,W> dst, bool eol = true)
        {
            dst.Delimit(F.Sequence, src.Seq);
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Signature, src.Sig);
            dst.Delimit(F.Attributes, src.Attribs);
            if(eol)
                dst.EmitEol();
            return ref dst;
        }
    }
}