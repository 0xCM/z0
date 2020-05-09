//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IEncoded<F> : IEquatable<F>, ILengthwise
        where F : struct, IEncoded<F>
    {
        // bool IsEmpty {get;}

        // bool IsNonEmpty {get;}
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