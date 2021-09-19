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

    public readonly struct AsmRecordFields
    {
        public AsmId Id {get;}

        readonly Index<AsmRecordField> Data;

        [MethodImpl(Inline)]
        public AsmRecordFields(AsmId id, AsmRecordField[] src)
        {
            Id = id;
            Data = src;
        }

        public ReadOnlySpan<AsmRecordField> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }
}