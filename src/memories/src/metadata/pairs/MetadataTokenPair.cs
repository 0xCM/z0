//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct MetadataTokenPair
    {
        [MethodImpl(Inline)]
        public static implicit operator Pair<MetadataToken>(MetadataTokenPair src)
            => (src.Subject, src.Owner);

        
        [MethodImpl(Inline)]
        public MetadataTokenPair(MetadataToken Subject, MetadataToken Owner)
        {
            this.Subject = Subject;
            this.Owner = Owner;
        }

        public MetadataToken Subject {get;}

        public MetadataToken Owner {get;}

        public MetadataPair<MetadataToken> Generalized
        {
            [MethodImpl(Inline)]
            get => new MetadataPair<MetadataToken>(Subject,Owner);
        }
    }
}