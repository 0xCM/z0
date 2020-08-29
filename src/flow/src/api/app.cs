//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;

    partial struct Flow
    {
        [MethodImpl(Inline), Op]
        public static IAppContext app()
            => ContextFactory.create();
    }
}