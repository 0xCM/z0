//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct JmpInfo
    {
        public JmpKind Kind {get;}

        public JccCode Code {get;}

        [MethodImpl(Inline)]
        public JmpInfo(JmpKind kind, JccCode code)
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
        public static implicit operator JmpInfo((JmpKind kind, JccCode code) src)
            => new JmpInfo(src.kind, src.code);

        public static JmpInfo Empty
        {
            [MethodImpl(Inline)]
            get => (JmpKind.None, 0);
        }
    }
}