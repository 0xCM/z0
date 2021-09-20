//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public class EtlDatasets
    {
        internal Index<AsmRecordField> AsmDefFieldData;

        internal Index<OpCodeSpec> OpCodeData;

        internal LineMap<AsmId> AsmDefMapData;

        internal LlvmRecordSources RecordSourceData;

        public LineMap<AsmId> AsmDefMap
        {
            [MethodImpl(Inline)]
            get => AsmDefMapData;
        }

        public LlvmRecordSources RecordSources
        {
            [MethodImpl(Inline)]
            get => RecordSourceData;
        }

        public ReadOnlySpan<AsmRecordField> AsmDefFields
        {
            [MethodImpl(Inline)]
            get => AsmDefFieldData.View;
        }

        public ReadOnlySpan<OpCodeSpec> OpCodes
        {
            [MethodImpl(Inline)]
            get => OpCodeData.View;
        }
    }
}