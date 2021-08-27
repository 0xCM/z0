//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct AsmDescriptor
    {
        public AsmId Id;

        public bit IsReturn;

        public bit IsBranch;

        public bit IsCompare;

        public bit IsMoveImm;

        public bit IsMoveReg;

        public bit IsCall;

        public StringAddress AsmString;
    }

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct AsmRecordField
    {
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