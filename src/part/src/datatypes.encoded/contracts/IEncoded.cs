//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IEncoded : IMeasured, ITextual
    {
        byte[] Storage {get;}

        int IMeasured.Length
            => Storage.Length;

        string ITextual.Format()
            => Storage.FormatHexBytes();
    }

    public interface IEncoded<F> : IEncoded, IEquatable<F>
        where F : struct, IEncoded<F>
    {

    }
}