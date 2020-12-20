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
    /// Represents the open type parameters defined by a method
    /// </summary>
    public readonly struct TypeParameters  : ITextual
    {
        public readonly TypeParamInfo[] Items;

        [MethodImpl(Inline)]
        public TypeParameters(TypeParamInfo[] reps)
            => Items = reps;

        public string Format(bool fence)
        {
            var content = string.Join(", ", Items.Select(x => x.Format(false)));
            return fence ?  ('<' + content + '>') : content;
        }

        public string Format()
            => Format(true);

        public int Count
            => Items.Length;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TypeParameters(TypeParamInfo[] src)
            => new TypeParameters(src);
    }
}