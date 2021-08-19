//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct EnumSpec
    {
        public Identifier Name;

        public ClrEnumKind DataType;

        public bool Flags;

        public bool SymbolSource;

        public Identifier Group;

        public TextBlock Description;

        public Index<Identifier> Names;

        public Index<ulong> Values;

        public Index<string> Symbols;

        public Index<string> Descriptions;
    }
}
