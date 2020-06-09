//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IEncoded<F> : IEquatable<F>, ILengthwise, ITextual
        where F : struct, IEncoded<F>
    {

    }

    public interface IEncoded<F,C> : IEncoded<F>
        where F : struct, IEncoded<F,C>
    {
        /// <summary>
        /// The encoded data, likely in bytes
        /// </summary>
        C Encoded {get;}
    }
}