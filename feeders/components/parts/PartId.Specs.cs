//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Components;

    public interface IPartId
    {
        PartId Id {get;}
    }

    public interface IPartId<P> : IPartId, ITypedLiteral<PartId>
        where P : IPartId, new()
    {
        PartId ITypedLiteral<PartId>.Class => Id;
    }

    public abstract class PartId<P> : IPartId<P>
        where P : IPartId, new()
    {
        public abstract PartId Id {get;}

        public static P Part => new P();        
    }

    public readonly struct PartArrow<S,T>
        where S : struct, IPartId 
        where T : struct, IPartId
    {
        public PartArrow(S source = default, T target = default)
        {
            this.Source = source;
            this.Target = target;
        }

        public S Source {get;}

        public T Target {get;}
    }
}