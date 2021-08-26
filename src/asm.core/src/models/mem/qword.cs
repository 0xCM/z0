//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmOperands
    {
        public readonly struct qword : ISizedTarget<qword>
        {
            public AsmAddress Target {get;}

            public AsmSizeClass SizeClass
                => AsmSizeClass.qword;

            [MethodImpl(Inline)]
            public qword(AsmAddress dst)
            {
                Target = dst;
            }

            [MethodImpl(Inline)]
            public static implicit operator qword(AsmAddress dst)
                => new qword(dst);
        }
    }
}