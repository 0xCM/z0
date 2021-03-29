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
            Description = EmptyString;
            _Token = z8;
        }

        public PrefixCodeAttribute(string description)
        {
            Description = description;
            _Token = z8;
        }

        public PrefixCodeAttribute(object token, string description)
        {
            _Token = token;
            Description = description;
        }

        object _Token {get;}

        public byte Token
            => (byte)_Token;

        public string Description {get;}
    }
}