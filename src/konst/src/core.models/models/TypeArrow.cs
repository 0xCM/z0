//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct TypeArrow
    {
        public Type Source {get;}

        public Type Target {get;}

        [MethodImpl(Inline)]
        public static implicit operator TypeArrow((Type src, Type dst) x)
            => new TypeArrow(x.src,x.dst);

        [MethodImpl(Inline)]
        public TypeArrow(Type src, Type dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.ArrowAxB, Source.Name, Target.Name);
    }
}