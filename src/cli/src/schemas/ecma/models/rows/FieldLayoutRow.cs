//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    public struct FieldLayoutRow : IRecord<FieldLayoutRow>
    {
        public RowKey Key;

        public uint Offset;

        /// <summary>
        /// Identifies a <see cref='FieldRow'/> record
        /// </summary>
        public RowKey Field;
    }
}