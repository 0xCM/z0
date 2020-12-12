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
    /// Defines a directed association between two data members
    /// </summary>
    public class ClrDataLink : ILink<ClrDataMember>
    {
        /// <summary>
        /// The supplier member
        /// </summary>
        public ClrDataMember Source {get;}

        /// <summary>
        /// The client member
        /// </summary>
        public ClrDataMember Target {get;}

        public string Identifier
            => text.concat(Source.Name, Colon, Source.DataType.Name, " -> ", Target.Name, Colon, Target.DataType.Name);

        [MethodImpl(Inline)]
        public ClrDataLink(ClrDataMember s, ClrDataMember t)
        {
            Source = s;
            Target = t;
        }

        const char Colon = ':';

        public string Format()
            => Identifier;


        public override string ToString()
            => Format();
    }

    /// <summary>
    /// Defines a directed association between two value members defined by two respective types
    /// </summary>
    /// <typeparam name="X">The source type</typeparam>
    /// <typeparam name="Y">The target type</typeparam>
    public readonly struct ClrDataLink<X,Y>
    {
        readonly ClrDataLink  Arrow;

        [MethodImpl(Inline)]
        public ClrDataLink(ClrDataMember s, ClrDataMember t)
            => Arrow = new ClrDataLink(s,t);

        /// <summary>
        /// The supplier member
        /// </summary>
        public ClrDataMember Source
        {
            [MethodImpl(Inline)]
            get => Arrow.Source;
        }

        /// <summary>
        /// The client member
        /// </summary>
        public ClrDataMember Target
        {
            [MethodImpl(Inline)]
            get => Arrow.Target;
        }

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => Arrow.Identifier;
        }

        public string Format()
            => Arrow.Format();


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ClrDataLink(ClrDataLink<X,Y> src)
            => src.Arrow;
    }
}