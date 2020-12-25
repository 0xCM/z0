//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct ClrEnumLiteralRecord : IRecord<ClrEnumLiteralRecord>
    {
        public const byte FieldCount = 8;

        public const string TableId = "clr.enums";

        /// <summary>
        /// The part in which the enum is defined
        /// </summary>
        public PartId PartId;

        /// <summary>
        /// The name of the defining type
        /// </summary>
        public StringRef TypeName;

        /// <summary>
        /// The metadata token of the defining type
        /// </summary>
        public CliKey TypeId;

        /// <summary>
        /// The name of the literal identifier
        /// </summary>
        public StringRef FieldName;

        /// <summary>
        /// The metadata token of the defining field
        /// </summary>
        public CliKey FieldId;

        /// <summary>
        /// The kind of primitive specialized by the enum
        /// </summary>
        public EnumLiteralKind DataType;

        /// <summary>
        /// The literal declaration order within the defining enum
        /// </summary>
        public uint Position;

        /// <summary>
        /// The primitive value
        /// </summary>
        public ulong LiteralValue;
    }
}