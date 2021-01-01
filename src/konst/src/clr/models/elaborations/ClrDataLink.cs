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
}