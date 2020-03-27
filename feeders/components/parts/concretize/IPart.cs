//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Components;

    public interface IPart : IPartId
    {
        /// <summary>
        /// The resolved assembly
        /// </summary>
        Assembly Owner {get;}

        /// <summary>
        /// The name of the assembly
        /// </summary>
        string Name {get;}        

        IBinaryResourceProvider ResourceProvider {get;}

    }

    public interface IPart<P> : IPart, IEquatable<P>
        where P : IPart<P>, new()   
    {
    }
}