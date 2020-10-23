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
    using static LetterTypes;

    partial struct Symbolic
    {
        [MethodImpl(Inline), Op]
        public static Perm4L perm(A a, B b, C c, D d)
            => Perm4L.ABCD;

        [MethodImpl(Inline), Op]
        public static Perm4L perm(A a, B b,  D d, C c)
            => Perm4L.ABDC;

        [MethodImpl(Inline), Op]
        public static Perm4L perm(A a, C c, B b,  D d)
            => Perm4L.ACBD;
    }
}