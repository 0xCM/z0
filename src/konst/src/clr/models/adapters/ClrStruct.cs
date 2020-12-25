//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiType(ApiNames.ClrStruct, true)]
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
            get => Definition;
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrType(ClrStruct src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrStruct src)
            => src.Definition;

        [MethodImpl(Inline)]
        internal static ClrStruct Unchecked(Type src)
            => new ClrStruct(src);

        public IEnumerable<ClrStruct> NestedTypes
            => Definition.GetNestedTypes().Select(t => new ClrStruct(t));
    }
}