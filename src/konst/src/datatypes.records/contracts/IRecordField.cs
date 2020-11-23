//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRecordField
    {
        Type RecordType {get;}

        /// <summary>
        /// The 0-based, declaration order of the field
        /// </summary>
        ushort FieldIndex {get;}

        ClrArtifactKey FieldKey {get;}

        string FieldName {get;}

        Type FieldType {get;}

        ByteSize FieldSize {get;}
    }

    [Free]
    public interface IRecordField<T> : IRecordField
        where T : struct
    {
        Type IRecordField.RecordType
            => typeof(T);
    }
}