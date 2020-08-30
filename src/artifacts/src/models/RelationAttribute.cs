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


    public readonly struct RelationAttribute
    {
        public readonly DirectedRelation Relation;

        public readonly asci32 Name;

        public readonly variant Value;

        [MethodImpl(Inline)]
        public static implicit operator RelationAttribute((DirectedRelation r, asci32 name, variant value) src)
            => new RelationAttribute(src.r, src.name, src.value);

        [MethodImpl(Inline)]
        public RelationAttribute(DirectedRelation r, asci32 name, variant value)
        {
            Relation = r;
            Name = name;
            Value = value;
        }
    }
}