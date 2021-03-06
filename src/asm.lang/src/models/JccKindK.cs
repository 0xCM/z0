//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct JccInfo
    {
        public JccKind Kind {get;}

        public JccCode Code {get;}

        [MethodImpl(Inline)]
        public JccInfo(JccKind kind, JccCode code)
        {
            Kind = kind;
            Code = code;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Kind == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Kind != 0;
        }

        [MethodImpl(Inline)]
        public static implicit operator JccInfo((JccKind kind, JccCode code) src)
            => new JccInfo(src.kind, src.code);

        public static JccInfo Empty
        {
            [MethodImpl(Inline)]
            get => (JccKind.None, 0);
        }
    }
}