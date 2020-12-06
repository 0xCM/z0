//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = CilTables;

    public readonly struct CilTableSpec : ITextual
    {
        public ClrTypeName TableName {get;}

        readonly TableSpan<CilFieldSpec> FieldSpecs;

        [MethodImpl(Inline)]
        public CilTableSpec(ClrTypeName name, CilFieldSpec[] cells)
        {
            TableName = name;
            FieldSpecs = cells;
        }

        public ReadOnlySpan<CilFieldSpec> Fields
        {
            [MethodImpl(Inline)]
            get => FieldSpecs.View;
        }

        public Count FieldCount
        {
            [MethodImpl(Inline)]
            get => FieldSpecs.Count;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}