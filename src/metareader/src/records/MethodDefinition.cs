//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using S = PartRecords.MethodDefinitionSpec;
    using F = PartRecords.MethodDefinitionField;
    using R = PartRecords.MethodDefinitionRecord;
    
    partial class PartRecords
    {
        public enum MethodDefinitionField : ushort
        {
            Sequence = 0,

        }

        public readonly struct MethodDefinitionRecord 
        {
            public int Sequence {get;}

            public string Format()
                => string.Empty;

            public string Format(char delimiter)
                => string.Empty;
        }

        public readonly struct MethodDefinitionSpec : IPartRecordSpec<S>
        {
            [MethodImpl(Inline)]
            public static implicit operator PartRecordKind(S src)
                => src.RecordType;

            public PartRecordKind RecordType 
                => PartRecordKind.MethodDefinition;            

            public override string ToString()
                => (this as ITextual).Format();
        }        
    }
}