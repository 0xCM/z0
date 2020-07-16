//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a directed association between a source and target values
    /// of the same type
    /// </summary>
    /// <term>Homogenous Link</term>
    /// <typeparam name="X">The source type</typeparam>
    public readonly struct Link<X> : ILink<X>
    {
        /// <summary>
        /// The source value
        /// </summary>
        public X Source { get; }

        /// <summary>
        /// The target value
        /// </summary>
        public X Target { get; }

        /// <summary>
        /// Canonical factory
        /// </summary>
        /// <param name="x"></param>
        public static explicit operator Link<X>((X x1, X x2) x)
            => new Link<X>(x.x1, x.x2);

        public static implicit operator Link<X,X>(Link<X> x)
            => new Link<X, X>(x.Source, x.Target);

        public static implicit operator Link<X>(Link<X,X> xy)
            => new Link<X>(xy.Source, xy.Target);

        public Link(X src, X dst)
        {
            Source = src;
            Target = dst;
        }

        /// <summary>
        /// The name of the link, presented in the form Source => Target
        /// </summary>
        public LinkIdentifier<X> Identity
            => (Source, Target);

        /// <summary>
        /// The name of the link, presented in the form Source => Target
        /// </summary>
        public LinkIdentifier Name
            => Identity;

        public override string ToString()
            => Identity.ToString();
    }

    /// <summary>
    /// Represents a directed association between a source and a target of
    /// (potentially) different types
    /// </summary>
    /// <typeparam name="X">The source type</typeparam>
    /// <typeparam name="Y">The target type</typeparam>
    /// <term>Heterogeneous Link</term>
    public readonly struct Link<X,Y> : ILink<X,Y>
    {           
        /// <summary>
        /// The source value
        /// </summary>
        public X Source { get; }

        /// <summary>
        /// The target value
        /// </summary>
        public Y Target { get; }

        /// <summary>
        /// Canonical factory
        /// </summary>
        /// <param name="x"></param>
        public static explicit operator Link<X,Y>((X,Y) x)
            => new Link<X,Y>(x.Item1,x.Item2);

        public Link(X src, Y dst)
        {
            Source = src;
            Target = dst;
        }

        public LinkIdentifier<X,Y> Identity
            => (Source, Target);

        /// <summary>
        /// Identifies the association
        /// </summary>
        public LinkIdentifier Name
            => Identity;

        public override string ToString()
            => Identity.Format();
    }
}