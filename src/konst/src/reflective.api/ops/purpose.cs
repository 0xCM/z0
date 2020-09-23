//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Reflex
    {
        [MethodImpl(Inline), Op]
        public static Purpose purpose(MemberInfo src)
            => tagged<MemberInfo,PurposeAttribute>(src)
              ? Purpose.Without
              : new Purpose(tag<MemberInfo,PurposeAttribute>(src).Description);
    }
}