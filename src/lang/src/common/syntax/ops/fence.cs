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

    partial struct SyntaxModels
    {
        [MethodImpl(Inline), Op]
        public static SyntaxFence fence(char left, char right)
            => new SyntaxFence(left,right);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SyntaxFence<T> fence<T>(T left, T right)
            where T : unmanaged
                => new SyntaxFence<T>(left,right);

    }
}