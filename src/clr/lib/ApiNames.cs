//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ApiNameAtoms;

    [LiteralProvider]
    readonly struct ApiNames
    {
        public const string ClrType = clr + dot + type;

        public const string ClrTypes = clr + dot + types;

        public const string ClrEnum = clr + dot + @enum;

        public const string ClrEnums = clr + dot + "enums" + dot + api;

        public const string ClrEnumLiteral = clr + dot + @enum + dot + literal;

        public const string ClrStruct = clr + dot + @struct;

        public const string ClrAssembly = clr + dot + assembly;

        public const string ClrField = clr + dot + field;

        public const string ClrMethod = clr + dot + method;

        public const string ClrProperty = clr + dot + property;

        public const string ClrRecords = clr + dot + records;

        public const string ClrReflex = clr + dot + "reflex";

        public const string ClrPrimitives = clr + dot + primitives;
    }
}