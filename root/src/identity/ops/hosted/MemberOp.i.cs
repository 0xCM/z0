//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;
        
    public interface IMemberOp
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

    public interface IMemberOp<T> : IMemberOp, IEquatable<T>, IFormattable<T>
        where T : IMemberOp<T>
    {
        string ICustomFormattable.Format()
            => Uri.Format();    
    }


}