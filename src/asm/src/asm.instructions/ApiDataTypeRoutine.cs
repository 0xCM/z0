//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    /// <summary>
    /// Describes a <see cref='ApiTypeInfo'/> member operation
    /// </summary>
    public readonly struct ApiDataTypeRoutine
    {
        /// <summary>
        /// The defining type
        /// </summary>
        public readonly ApiTypeInfo DataType;

        /// <summary>
        /// The defining method
        /// </summary>
        public readonly IdentifiedMethod Member;

        /// <summary>
        /// The asm content derived from the defining method
        /// </summary>
        public readonly AsmMemberRoutine Routine;

        [MethodImpl(Inline)]
        public ApiDataTypeRoutine(in ApiTypeInfo type, in IdentifiedMethod member, in AsmMemberRoutine routine)
        {
            DataType = type;
            Member = member;
            Routine = routine;
        }
    }
}