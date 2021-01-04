//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ClrStruct
    {
        public Type Definition {get;}

        [MethodImpl(Inline)]
        public ClrStruct(Type src)
            => Definition = src;

        public ClrType Generalized
        {
            [MethodImpl(Inline)]
            get => Definition;
        }

        public ClrTypeName Name
        {
            [MethodImpl(Inline)]
            get => new ClrTypeName(Definition.FullName);
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrType(ClrStruct src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrStruct src)
            => src.Definition;

        public IEnumerable<ClrStruct> NestedTypes
            => Definition.GetNestedTypes().Select(t => new ClrStruct(t));
    }
}