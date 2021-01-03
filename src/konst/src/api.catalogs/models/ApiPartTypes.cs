//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents the types defined by a part
    /// </summary>
    public readonly struct ApiPartTypes
    {
        public PartId Part {get;}

        public Type[] Types {get;}

        [MethodImpl(Inline)]
        public ApiPartTypes(PartId part, Type[] types)
        {
            Part = part;
            Types = types;
        }
    }
}