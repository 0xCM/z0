//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Captures a 0-based argument index
    /// </summary>
    public struct CmdArgPos
    {
        public byte Index;

        [MethodImpl(Inline)]
        public CmdArgPos(byte src)
            => Index = src;

        public ArgPosKind Indicator
        {
            [MethodImpl(Inline)]
            get => (ArgPosKind)((Index * 2) << 2);
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdArgPos(byte src)
            => new CmdArgPos(src);

        [MethodImpl(Inline)]
        public static CmdArgPos operator ++(CmdArgPos src)
            => new CmdArgPos((byte)(src.Index + 1));

        [MethodImpl(Inline)]
        public static implicit operator byte(CmdArgPos src)
            => src.Index;

        [MethodImpl(Inline)]
        public static implicit operator CmdArgPos(int src)
            => new CmdArgPos((byte)src);
    }
}