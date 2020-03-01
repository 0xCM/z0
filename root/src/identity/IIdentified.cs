//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Characterizes an association between a subject and its identity, similar to a key-value pair
    /// </summary>
    /// <typeparam name="K">Khe reification type</typeparam>
    /// <typeparam name="V">Khe subject type</typeparam>
    public interface IIdentified<K,V> : IIdentity<K>
        where K : IIdentified<K,V>, new()         
    {   
        /// <summary>
        /// Khe identified thing
        /// </summary>
        V Subject {get;}

        [MethodImpl(Inline)]
        void Deconstruct(out string id, out V subject)
        {
            id = Identifier;
            subject = Subject;
        }
    }
}