//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Reflection;

    public interface IApiMethod : ICustomFormattable
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

        /// The globally-unique operation uri
        /// </summary>
        OpUri Uri
            => OpUri.hex(Host, Method.Name, Id);        

        string ICustomFormattable.Format()
            => Uri.Format();    
    }

    public interface IApiMember : IApiMethod
    {
        /// <summary>
        /// The method's kind identifier if it exists
        /// </summary>
        OpKindId? KindId {get;}
    
    }        

    public interface IApiMember<T> : IApiMember, IEquatable<T>, IFormattable<T>, INullary<T>
        where T : struct, IApiMember<T>
    {

    }
}