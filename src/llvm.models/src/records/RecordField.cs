//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential)]
    public struct RecordField
    {
        public string DataType;

        public string Name;

        public string Value;

        public RecordField(string type, string name, string value)
        {
            DataType = type;
            Name = name;
            Value = value;
        }

        public string Format()
            => string.Format("{0} {1} = {2}",
                text.ifempty(DataType, RP.Empty),
                text.ifempty(Name, RP.Empty),
                text.ifempty(Value, RP.Empty)
                );

        public override string ToString()
            => Format();

        public static RecordField Empty
            => new RecordField(EmptyString,EmptyString,EmptyString);
    }
}