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
    public readonly struct ApiDataTypeRoutines
    {
        readonly TableSpan<ApiDataTypeRoutine> Members;

        public ApiDataType DataType {get;}

        [MethodImpl(Inline)]
        public ApiDataTypeRoutines(ApiDataType type, TableSpan<ApiDataTypeRoutine> members)
        {
            DataType = type;
            Members = members;
        }

        public uint MethodCount
        {
            [MethodImpl(Inline)]
            get => Members.Count;
        }

        public ReadOnlySpan<ApiDataTypeRoutine> View
        {
            [MethodImpl(Inline)]
            get => Members.View;
        }
        public ref ApiDataTypeRoutine LeadingMember
        {
            [MethodImpl(Inline)]
            get => ref first(Members.Edit);
        }
    }
}