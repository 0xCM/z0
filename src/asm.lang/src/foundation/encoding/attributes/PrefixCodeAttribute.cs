//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;

    [AttributeUsage(AttributeTargets.Field)]
    public class PrefixCodeAttribute : Attribute
    {
        public PrefixCodeAttribute()
        {
            _Token = z8;
        }

        public PrefixCodeAttribute(string description)
        {
            _Token = z8;
        }

        public PrefixCodeAttribute(object token)
        {
            _Token = token;
        }

        object _Token {get;}

        public byte Token
            => (byte)_Token;
    }
}