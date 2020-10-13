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

    public readonly struct CaptureSubjects
    {
        [MethodImpl(Inline)]
        public static Subject[] CapturedAsm()
            => array<Subject>("capture","asm");

        [MethodImpl(Inline)]
        public static Subject[] CapturedCil()
            => array<Subject>("capture","cil");
    }
}