//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Specifies a md token
    /// </summary>
    public struct Token
    {
        public uint Value {get;}

        [MethodImpl(Inline)]
        public Token(uint value)
            => Value = value;

        [MethodImpl(Inline)]
        public static implicit operator Token(uint src)
            => new Token(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(Token src)
            => src.Value;
    }

}