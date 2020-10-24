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
        public static Fence fence(char left, char right)
            => new Fence(left,right);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Fence<T> fence<T>(T left, T right)
            where T : unmanaged
                => new Fence<T>(left,right);
    }
}