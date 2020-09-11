//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct ApiDataTypeRoutine
    {
        public readonly ApiDataType DataType;

        public readonly IdentifiedMethod Member;

        public readonly AsmMemberRoutine Routine;

        [MethodImpl(Inline)]
        public ApiDataTypeRoutine(in ApiDataType type, in IdentifiedMethod member, in AsmMemberRoutine routine)
        {
            DataType = type;
            Member = member;
            Routine = routine;
        }
    }

}