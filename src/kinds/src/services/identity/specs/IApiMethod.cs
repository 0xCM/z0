//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Reflection;

    public interface IApiMethod : ITextual, IIdentified<OpIdentity>
    {
        /// <summary>
        /// The globally-unique host uri
        /// </summary>
        ApiHostUri HostUri {get;}

        /// <summary>
        /// The hosted method
        /// </summary>
        MethodInfo Method {get;}        

        /// <summary>
        /// The method's kind identifier if it exists
        /// </summary>
        OpKindId KindId 
            => OpKindId.None;    

        /// The globally-unique operation uri
        /// </summary>
        OpUri Uri
            => OpUri.hex(HostUri, Method.Name, Id);        
        
        string ITextual.Format()
            => Uri.Format();    
    }
}