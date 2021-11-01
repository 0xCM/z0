//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm.records
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential, Pack=1), Record(TableId)]
    public struct TableGenField
    {
        public const string TableId = "llvm.fields";

        public const string RowFormat = "{0,-64} | {1,-32} | {2,-32} | {3}";

        public static string RowHeader
            => string.Format(RowFormat, nameof(Id), nameof(DataType), nameof(Name), nameof(Value));

        public Identifier Id;

        public RecordField FieldContent;

        public string DataType
        {
            [MethodImpl(Inline)]
            get => FieldContent.DataType;
        }

        public string Name
        {
            [MethodImpl(Inline)]
            get => FieldContent.Name;
        }

        public string Value
        {
            [MethodImpl(Inline)]
            get => FieldContent.Value;
        }

        public string Format()
            => string.Format("{0}.{1}:{2} = {3}", Id, Name, DataType, Value);

        public override string ToString()
            => Format();
    }
}