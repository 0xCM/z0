//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    /// <summary>
    /// Represents the types defined by a part
    /// </summary>
    public readonly struct PartTypes
    {
        [MethodImpl(Inline)]
        public static PartTypes from(IPart src)
            => new PartTypes(src.Id, src.Owner.Types());
        
        public readonly PartId Part;

        public readonly Type[] Types;
        
        [MethodImpl(Inline)]
        public PartTypes(PartId part, Type[] types)
        {
            Part = part;
            Types = types;
        }
    }   
}