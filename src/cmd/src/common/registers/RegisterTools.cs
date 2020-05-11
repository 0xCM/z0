//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using I = RegisterIndex;
    using W = RegisterWidth;

    class RegisterTools
    {
        public const ulong IndexFilter = (ulong)I.All;

        public const ulong WidthFilter = (ulong)W.All;

        public const int IX_MinPower = (int)I.MinPower;

        [MethodImpl(Inline)]
        public static ulong u64(RegisterKind src)
            => (ulong)src;

        [MethodImpl(Inline)]
        public static RegisterSlot slot(ulong src)
            => (RegisterSlot)src;
    }
}