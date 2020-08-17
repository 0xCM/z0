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
        
        public AsmRoutine Function {get;}

        public CapturedCode Code {get;}
 
        [MethodImpl(Inline)]
        public static implicit operator AsmRoutineCode((AsmRoutine f, CapturedCode code) src)
            => new AsmRoutineCode(src.f, src.code);
        
        [MethodImpl(Inline)]
        public AsmRoutineCode(AsmRoutine f, CapturedCode code)
        {
            Function = f;
            Code = code;
        }       

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (Function == null || Function.IsEmpty) && Code.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => (Function != null && Function.IsNonEmpty) && Code.IsNonEmpty;
        }
    }
}