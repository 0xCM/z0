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

    using F = FormatDomain;

    [ApiHost(ApiNames.ParseDomain, true)]
    public readonly partial struct ParseDomain
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static Fence fence(char left, char right)
            => new Fence(left,right);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Fence<T> fence<T>(T left, T right)
            where T : unmanaged
                => new Fence<T>(left,right);

        [MethodImpl(Inline), Op]
        public static string format(in Fence src)
        {
            const string Pattern = "(<<{0}...{1}>>)";
            return F.format(Pattern, src.Left, src.Right);
        }
    }
}