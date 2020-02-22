//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    [Flags]
    public enum ApiHostKind
    {
        None = 0,

        Direct = 1,

        Generic = 2,

        DirectAndGeneric = Direct | Generic
    }

    public static class ApiHostKindOps
    {
        [MethodImpl(Inline)]
        public static bool DefinesDirectOps(this ApiHostKind src)
            => (src & ApiHostKind.Direct) != 0;

        [MethodImpl(Inline)]
        public static bool DefinesGenericOps(this ApiHostKind src)
            => (src & ApiHostKind.Generic) != 0;

        
        [MethodImpl(Inline)]
        public static bool IsSome(this ApiHostKind src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bool IsNone(this ApiHostKind src)
            => src == 0;
    }

}