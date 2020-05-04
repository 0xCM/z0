//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Characterizes code with a known uri
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="C">The code type</typeparam>
    public interface IUriCode<F,C> : IIdentifiedCode<F,C>
        where F : struct, IEncoded<F,C>
    {
        /// <summary>
        /// The identifying uri
        /// </summary>
        OpUri Uri {get;}

        OpIdentity IIdentified<OpIdentity>.Id => Uri.OpId;
    }
}