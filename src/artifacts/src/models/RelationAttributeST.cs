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
    using static ArtifactModel;

    public readonly struct RelationAttribute<S,T>
    {
        public readonly asci32 Name;

        public readonly variant Value;

        public static implicit operator RelationAttribute<S,T>(Paired<asci32,variant> src)
            => new RelationAttribute<S,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public RelationAttribute(asci32 name, variant value)
        {
            Name = name;
            Value = value;
        }
    }
}