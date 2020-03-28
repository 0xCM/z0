//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Reflection;

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