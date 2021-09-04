//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct AsmRecordField
    {
        public const string TableId = "llvm.fields";

        public const string RowFormat = "{0,-32} | {1,-32} | {2,-32} | {3}";

        public static string RowHeader
            => string.Format(RowFormat, nameof(Id), nameof(Type), nameof(Name), nameof(Value));

        public AsmId Id;

        public RecordField FieldContent;

        public string Type
        {
            [MethodImpl(Inline)]
            get => FieldContent.Type;
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
            => string.Format("{0}.{1}:{2} = {3}", Id, Name, Type, Value);

        public override string ToString()
            => Format();
    }
}