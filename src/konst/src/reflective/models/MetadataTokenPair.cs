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
        public readonly MetadataToken Subject;

        public readonly MetadataToken Owner;

        [MethodImpl(Inline)]
        public static implicit operator Pair<MetadataToken>(MetadataTokenPair src)
            => (src.Subject, src.Owner);
        
        [MethodImpl(Inline)]
        public MetadataTokenPair(MetadataToken subject, MetadataToken owner)
        {
            Subject = subject;
            Owner = owner;
        }

        public MetadataPair<MetadataToken> Generalized
        {
            [MethodImpl(Inline)]
            get => new MetadataPair<MetadataToken>(Subject,Owner);
        }
    }
}