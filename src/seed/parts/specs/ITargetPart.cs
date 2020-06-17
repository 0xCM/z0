//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Characterizes a directed dependency d:S -> T from a client s:S to a suppler t:T
    /// </summary>
    /// <typeparam name="S">The source client type</typeparam>
    /// <typeparam name="T">The target supplier type</typeparam>
    public interface ITargetPart<S,T>
        where S : struct, IPartId 
        where T : struct, IPartId
    {
        S Source {get;}

        T Target {get;}

        [MethodImpl(Inline)]
        bool Equals<K>(K part)
            where K : ITargetPart<S,T>
                => Source.Id == part.Source.Id && Target.Id == part.Target.Id;
    }
}