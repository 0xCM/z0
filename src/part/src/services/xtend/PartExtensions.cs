//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static bool DefinesDirectOps(this ApiHostKind src)
            => (src & ApiHostKind.Direct) != 0;

        [MethodImpl(Inline)]
        public static bool DefinesGenericOps(this ApiHostKind src)
            => (src & ApiHostKind.Generic) != 0;                
            
        [MethodImpl(Inline)]
        public static string Format(this PartId id)
            => Part.format(id);

        [MethodImpl(Inline)]
        public static string Format(this ExternId id)
            => Part.format(id);

        [MethodImpl(Inline)]
        public static PartId Id(this Assembly src)
            => Part.id(src);
    }

    partial class XTend
    {
    }    


}