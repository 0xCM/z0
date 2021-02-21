//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Rules;

    partial class text
    {
        [MethodImpl(Inline), Op]
        public static Fence<char> fence(char left, char right)
            => Rules.fence(left,right);

        [MethodImpl(Inline), Op]
        public static Fence<string> fence(string left, string right)
            => Rules.fence(left,right);
    }
}