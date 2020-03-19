//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IApiMember
    {
        /// <summary>
        /// The globally-unique host uri
        /// </summary>
        ApiHostUri Host {get;}

        /// <summary>
        /// The host-relative operation identifier
        /// </summary>
        OpIdentity Id {get;}

        /// <summary>
        /// The hosted method
        /// </summary>
        MethodInfo Method {get;}

        /// <summary>
        /// The method's kind identifier if it exists
        /// </summary>
        OpKindId? KindId {get;}

        /// <summary>
        /// The globally-unique operation uri
        /// </summary>
        OpUri Uri
            => OpUri.hex(Host, Method.Name, Id);        
    }        

    public interface IApiMember<T> : IApiMember, IEquatable<T>, IFormattable<T>
        where T : IApiMember<T>
    {
        string ICustomFormattable.Format()
            => Uri.Format();    
    }
}