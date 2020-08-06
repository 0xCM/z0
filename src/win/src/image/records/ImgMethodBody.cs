//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Data;

    using static Konst;    

    public enum ImgMethodBodyField : uint
    {
        Sig,

        Name,

        Rva,

        Cil,
    }
    
    public struct ImgMethodBody : ITable<ImgMethodBodyField,ImgMethodBody>
    {
        public BinaryCode Sig;

        public string Name;
        
        public Address32 Rva;

        public BinaryCode Cil;

        public string Format()
        {
            var dst = EmptyString.Build();
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(Sig.Format().PadRight(80));
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(Name.PadRight(50));
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(Rva.Format().PadRight(12));
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(Cil.Format());

            return dst.ToString();
        }

        public static string Header
            => text.concat(FieldDelimiter, Space,
                "Signature".PadRight(80),  FieldDelimiter,  Space,
                "Method".PadRight(50), FieldDelimiter,  Space,
                "Rva".PadRight(12), FieldDelimiter, Space,
                "Il");
    }
}