//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    public interface IMetaRecordKind : ITextual
    {
        MetaRecordKind RecordType {get;}   

        byte FieldCount => 0;

        ReadOnlySpan<string> HeaderFields => new string[0]{};    

        ReadOnlySpan<byte> FieldWidths => new byte[0]{};

        string HeaderText => string.Empty;     

        string ITextual.Format() => RecordType.ToString();
    }

    public interface IMetaRecordKind<R> : IMetaRecordKind
        where R : unmanaged, IMetaRecordKind<R>
    {
        
    }
    
    public enum MetaRecordKind : byte
    {
        None = 0,

        String = 1,

        Blob = 2,

        Constant = 3,

        Field = 4,

        ManifestResource = 5,

        Literal = 6
    }
}