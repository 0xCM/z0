//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IEncoded<F> : IByteSpanProvider<F>, IEquatable<F>, ITextual<F>
        where F : struct, IEncoded<F>
    {
        
    }

    public interface IEncoded<F,C> : IEncoded<F>, IContented<C>
        where F : struct, IEncoded<F,C>
    {

    }

    public interface ILocatedCode<F,C> : IEncoded<F,C>, IAddressable
        where F : struct, IEncoded<F,C>
    {

    }

}