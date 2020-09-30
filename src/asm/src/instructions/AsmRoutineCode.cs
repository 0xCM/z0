//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmRoutineCode
    {
        public static AsmRoutineCode Empty
            => default;

        public AsmRoutine Routine {get;}

        public ApiCaptureBlock Code {get;}


        [MethodImpl(Inline)]
        public static implicit operator AsmRoutineCode((AsmRoutine f, ApiCaptureBlock code) src)
            => new AsmRoutineCode(src.f, src.code);

        [MethodImpl(Inline)]
        public AsmRoutineCode(AsmRoutine f, ApiCaptureBlock code)
        {
            Routine = f;
            Code = code;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (Routine == null || Routine.IsEmpty) && Code.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => (Routine != null && Routine.IsNonEmpty) && Code.IsNonEmpty;
        }
    }
}