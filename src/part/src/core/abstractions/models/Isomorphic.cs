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
    /// Captures a <see cref='IIsomorhphic'/> relationship between two types
    /// </summary>
    public readonly struct Isomorphic : IIsomorhphic
    {
        public Type SourceType {get;}

        public Type TargetType {get;}

        [MethodImpl(Inline)]
        public Isomorphic(Type src, Type dst)
        {
            SourceType = src;
            TargetType = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator Isomorphic((Type src, Type dst) x)
            => new Isomorphic(x.src, x.dst);

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("<->", SourceType.Name, TargetType.Name);

        public override string ToString()
            => Format();
    }
}