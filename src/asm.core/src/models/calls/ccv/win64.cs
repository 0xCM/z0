//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct CallCv
    {
        public readonly struct win64 : ICallCv<win64>
        {
            public CcvKind Kind => CcvKind.WinX64;

            [MethodImpl(Inline)]
            public static implicit operator win64(CcvKind src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator CcvKind(win64 src)
                => src.Kind;
        }
    }
}