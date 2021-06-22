//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    /// <summary>
    /// Defines a c/c++/c# style enumeration
    /// </summary>
    public struct EnumType
    {
        public string Namespace;

        public string Name;

        public ConstantKind DataType;

        public string Description;

        public Index<EnumLiteral> Literals;
    }
}