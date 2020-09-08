//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableField<F,T>
        where F : unmanaged, Enum
        where T : struct, ITable
    {
        public StringRef FieldName {get;}

        public F FieldId {get;}

        public Type DataType {get;}

        public RenderWidth<ushort> RenderWidth {get;}

        public ByteSize FieldSize {get;}

        [MethodImpl(Inline)]
        public TableField(string name, F id, Type dt, ushort rw = default, ByteSize size = default)
        {
            FieldName = name;
            FieldId = id;
            DataType = dt;
            RenderWidth = rw;
            FieldSize = size;
        }
    }
}