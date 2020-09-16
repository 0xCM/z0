//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiDataTypeIndex
    {
        readonly TableSpan<ApiDataType> _DataTypes;

        readonly TableSpan<ApiDataTypeRoutines> _Routines;

        readonly TableSpan<uint> _Lookup;

        [MethodImpl(Inline)]
        public ApiDataTypeIndex(TableSpan<ApiDataType> types, TableSpan<ApiDataTypeRoutines> members, TableSpan<uint> lookup)
        {
            _DataTypes = types;
            _Routines = members;
            _Lookup = lookup;
        }

        public Span<ApiDataType> DataTypes
        {
            [MethodImpl(Inline)]
            get => _DataTypes.Edit;
        }

        public Span<ApiDataTypeRoutines> Routines
        {
            [MethodImpl(Inline)]
            get => _Routines.Edit;
        }

        public Span<uint> Lookup
        {
            [MethodImpl(Inline)]
            get => _Lookup.Edit;
        }
    }
}