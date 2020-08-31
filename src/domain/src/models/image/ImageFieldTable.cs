//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum ImageFieldTableField : ushort
    {
        Sequence,

        Name,

        Signature,

        Attributes,
    }

    public enum ImageFieldTabledWidth : ushort
    {
        Sequence = 12,

        Name = 60,

        Signature = 30,

        Attributes = 10,
    }

    [Table]
    public struct ImageFieldTable
    {
        public Count32 Seq;

        public ImageLiteralFieldTable Name;

        public BinaryCode Sig;

        public string Attribs;

        [MethodImpl(Inline)]
        public ImageFieldTable(Count32 seq, ImageLiteralFieldTable name, ImgBlobRecord sig, string attribs)
        {
            Seq = seq;
            Name = name;
            Sig = sig.Data;
            Attribs = attribs;
        }
    }
}