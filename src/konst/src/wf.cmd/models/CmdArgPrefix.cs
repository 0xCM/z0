//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Datatype]
    public readonly struct CmdArgPrefix
    {
        public static CmdArgPrefix Empty
            => default;

        public static CmdArgPrefix DoubleDash
            => new CmdArgPrefix(AsciCharCode.Dash, AsciCharCode.Dash);

        public static CmdArgPrefix Dash
            => new CmdArgPrefix(AsciCharCode.Dash);

        public static CmdArgPrefix FSlash
            => new CmdArgPrefix(AsciCharCode.FSlash);

        public static CmdArgPrefix Default
            => DoubleDash;

        internal readonly AsciCharCode C0;

        internal readonly AsciCharCode C1;

        [MethodImpl(Inline)]
        internal CmdArgPrefix(AsciCharCode c0)
        {
            C0 = c0;
            C1 = AsciCharCode.Null;
        }

        [MethodImpl(Inline)]
        internal CmdArgPrefix(AsciCharCode c0, AsciCharCode c1)
        {
            C0 = c0;
            C1 = c1;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => C0 == AsciCharCode.Null;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => C0 != AsciCharCode.Null;
        }

        public byte Length
        {
            [MethodImpl(Inline)]
            get => IsEmpty ? 0 : (C1 == AsciCharCode.Null ? 1 : 2);
        }

        [MethodImpl(Inline)]
        public string Format()
            => CmdFormat.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator string(CmdArgPrefix src)
            => src.Format();
    }
}