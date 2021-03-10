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
    public class ClrLink : ILink<ClrMember>
    {
        /// <summary>
        /// The supplier member
        /// </summary>
        public ClrMember Source {get;}

        /// <summary>
        /// The client member
        /// </summary>
        public ClrMember Target {get;}

        public string Identifier
            => text.concat(Source.Name, Colon, Source.Name, " -> ", Target.Name, Colon, Target.Name);

        [MethodImpl(Inline)]
        public ClrLink(ClrMember s, ClrMember t)
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
}