//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct AsmMemberRoutine : IComparable<AsmMemberRoutine>
    {
        /// <summary>
        /// The defining member
        /// </summary>
        public IdentifiedMethod Member;

        /// <summary>
        /// The x86 encoded content
        /// </summary>
        public ApiCaptureBlock Encoded;

        /// <summary>
        /// The assembly routine
        /// </summary>
        public AsmRoutine Routine;

        /// <summary>
        /// The formatted assembly instructions
        /// </summary>
        public string Asm;

        public MemoryAddress Base
        {
            [MethodImpl(Inline)]
            get => Encoded.BaseAddress;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Encoded.Length;
        }

        public int CompareTo(AsmMemberRoutine src)
            => Base.CompareTo(src.Base);
    }
}