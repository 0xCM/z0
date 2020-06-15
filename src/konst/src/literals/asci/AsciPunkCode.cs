//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using S = AsciPunk;

    public enum AsciPunkCode : byte
    {
        /// <summary>
        /// The '&' character code 38
        /// </summary>
        Amp = (byte)S.Amp,

        /// <summary>
        /// The '.' character code 46
        /// </summary>
        Dot = (byte)S.Dot,

        /// <summary>
        /// The ' ' character code 32
        /// </summary>
        Space = (byte)S.Space,

        /// <summary>
        /// The '#' character code 35
        /// </summary>
        Hash = (byte)S.Hash,

        /// <summary>
        /// The '$' character code 36
        /// </summary>
        Dollar = (byte)S.Dollar,

        /// <summary>
        /// The '@' character code 64
        /// </summary>
        At = (byte)S.At,

        /// <summary>
        /// The '\\' character code 92
        /// </summary>
        BS = (byte)S.BS,

        /// <summary>
        /// The '_' character code 95
        /// </summary>
        US = (byte)S.US,

        /// <summary>
        /// The ',' character code 44
        /// </summary>
        Comma = (byte)S.Comma,

        /// <summary>
        /// The '|' character code 124
        /// </summary>
        Pipe = (byte)S.Pipe,

        /// <summary>
        /// The '?' character code 63
        /// </summary>
        QU = (byte)S.QU,
    }
}