//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    public struct FieldLayoutRow : IRecord<FieldLayoutRow>
    {
        public RowKey Key;

        public int Offset;

        public int Field;
    }

}