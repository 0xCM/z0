//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.CompilerServices;

    using static Root;


    public readonly struct LlvmDataType
    {
        public static LlvmDataType parse(string src)
        {
            if(src.Equals("bit"))
                return new LlvmDataType(src, DataKind.Bit);
            else if(src.Equals("string"))
                return new LlvmDataType(src, DataKind.String);
            else if(src.Equals("int"))
                return new LlvmDataType(src, DataKind.Int);
            else if(src.Equals("dag"))
                return new LlvmDataType(src, DataKind.Dag);
            else if(src.StartsWith("bits"))
                return new LlvmDataType(src, DataKind.Bits);
            else if(src.StartsWith("list"))
                return new LlvmDataType(src, DataKind.List);
            else
                return new LlvmDataType(src,0);
        }


        public Identifier Decl {get;}

        public DataKind Kind {get;}

        [MethodImpl(Inline)]
        public LlvmDataType(Identifier decl, DataKind kind)
        {
            Decl = decl;
            Kind = kind;
        }

        public bool IsParametric
            => Decl.Content.Contains(Chars.Lt) &&  Decl.Content.Contains(Chars.Gt);

        public bool IsKnown => Kind != 0;

        public bool IsBits => Kind == DataKind.Bits;

        public bool IsBit => Kind == DataKind.Bit;

        public bool IsString => Kind == DataKind.String;

        public bool IsInt => Kind == DataKind.Int;

        public bool IsDag => Kind == DataKind.Dag;

        public bool TypeArgs(out string dst)
            => text.unfence(Decl, (Chars.Lt, Chars.Gt), out dst);

        [SymSource]
        public enum DataKind : byte
        {
            Other,

            Bit,

            [Symbol("string")]
            String,

            [Symbol("int")]
            Int,

            [Symbol("list<{0}>")]
            List,

            [Symbol("bits<{0}>")]
            Bits,

            Dag,
        }
   }
}