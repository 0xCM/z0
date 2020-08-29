//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IEncoded
    {
        BinaryCode Encoded  => BinaryCode.Empty;
    }

    public interface IEncoded<F> : IEncoded, IEquatable<F>, IMeasured, ITextual
        where F : struct, IEncoded<F>
    {

    }

    public interface IEncoded<F,C> : IEncoded<F>
        where F : struct, IEncoded<F,C>
    {
        /// <summary>
        /// The encoded data
        /// </summary>
        new C Encoded {get;}
    }
}