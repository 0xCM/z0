//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IEither : IMonadic
    {
        /// <summary>
        /// Specifies whether the left alternative exists
        /// </summary>
        bool IsLeft { get; }

        /// <summary>
        /// Specifies whether the right alternative exists
        /// </summary>
        bool IsRight { get; }
    }

    public interface IEither<L, R> : IEither
    {
        /// <summary>
        /// If <see cref="IsLeft"/> is true, specifies the value of the left alternative
        /// </summary>
        L Left { get; }


        /// <summary>
        /// If <see cref="IsRight"/> is true, specifies the value of the right alternative
        /// </summary>
        R Right { get; }

    }
}