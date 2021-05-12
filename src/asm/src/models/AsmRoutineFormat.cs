//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public class AsmRoutineFormat : ITextual
    {
        public AsmRoutine Routine {get;}

        public string Rendered {get;}

        [MethodImpl(Inline)]
        public AsmRoutineFormat(AsmRoutine src, string format)
        {
            Routine = src;
            Rendered =  format;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Rendered;

        public override string ToString()
            => Rendered;

        // public AsmSourceBlock AsmSource()
        //     => Rendered.lines


        [MethodImpl(Inline)]
        public static implicit operator AsmRoutineFormat((AsmRoutine routine, string format) src)
            => new AsmRoutineFormat(src.routine, src.format);
    }
}