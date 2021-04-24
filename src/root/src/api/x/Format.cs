//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class XApi
    {
        [MethodImpl(Inline), Op]
        public static bool IsDefined(this ApiClassKind src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bool IsUserApi(this ApiClassKind src)
            => src.IsDefined() && !src.IsOpaque();

        [MethodImpl(Inline), Op]
        public static string Format(this ApiClassKind src)
            => src.IsOpaque() ? "opaque" : src.ToString().ToLower();

        public static TernaryBitLogicKind Next(this TernaryBitLogicKind src)
            => src != TernaryBitLogicKind.XFF
                ? (TernaryBitLogicKind)((uint)(src) + 1u)
                : TernaryBitLogicKind.X00;

        public static string Format(this TernaryBitLogicKind kind)
            => kind.ToString();

        public static string Format<T>(this TernaryBitLogicKind kind, T arg1, T arg2, T arg3)
            => $"{kind.Format()}({arg1}, {arg2}, {arg3})";
    }
}