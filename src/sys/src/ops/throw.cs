//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
            
    using static OpacityKind;

    partial struct sys
    {        
        [MethodImpl(NotInline), Opaque(Throw)]
        public static void @throw(string msg)
            => throw new Exception(msg);

        [MethodImpl(NotInline), Opaque(Throw)]
        public static void @throw(Exception e)
            => throw e;

        [MethodImpl(NotInline), Opaque(Throw)]
        public static T @throw<T>(Exception e)
            => throw e;

    }
}