//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public class EnumSpec
    {
        public Identifier Name;

        public ClrEnumKind DataType;

        public bool Flags;

        public bool SymbolSource;

        public Identifier Group;

        public TextBlock Description;

        public Index<Identifier> Names;

        public Index<SymVal> Values;

        public Index<SymExpr> Symbols;

        public Index<string> Descriptions;
    }
}
