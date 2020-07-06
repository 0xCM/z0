//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MetadataPair<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public static implicit operator MetadataPair<T>(in ConstPair<T> src)
            => new MetadataPair<T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator MetadataPair<T>((T Subject, T Owner) src)
            => new MetadataPair<T>(src.Subject, src.Owner);
        
        [MethodImpl(Inline)]
        public MetadataPair(in T Subject, in T Owner)
        {
            this.Subject = Subject;
            this.Owner = Owner;
        }
        
        public T Subject {get;}

        public T Owner {get;}
    }
}