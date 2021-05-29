//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    public readonly struct LiteralCover<C> : ILiteralCover<LiteralCover<C>>
        where C : struct, ILiteralCover<C>
    {
        public C Cover {get;}

        public FieldInfo[] Covered {get;}

        [MethodImpl(Inline)]
        public LiteralCover(C src, FieldInfo[] covered)
        {
            Cover = src;
            Covered = typeof(C).Fields();
        }
    }
}