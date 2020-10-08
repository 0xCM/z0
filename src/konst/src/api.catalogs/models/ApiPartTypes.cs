//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    /// <summary>
    /// Represents the types defined by a part
    /// </summary>
    public readonly struct ApiPartTypes
    {
        public readonly PartId Part;

        public readonly Type[] Types;

        [MethodImpl(Inline)]
        public ApiPartTypes(PartId part, Type[] types)
        {
            Part = part;
            Types = types;
        }
    }
}