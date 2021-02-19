//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct EnumLiteral
    {
        /// <summary>
        /// The literal's declaration order
        /// </summary>
        public uint Order;

        public Literal Value;

        public TextBlock Description;

        [MethodImpl(Inline)]
        public EnumLiteral(uint order, Literal value, TextBlock desc)
        {
            Order = order;
            Value = value;
            Description = desc;
        }
    }

    public struct EnumLiteral<T>
    {
        /// <summary>
        /// The literal's declaration order
        /// </summary>
        public uint Order;

        public Literal<T> Value;

        public TextBlock Description;

        [MethodImpl(Inline)]
        public EnumLiteral(uint order, Literal<T> value, TextBlock desc)
        {
            Order = order;
            Value = value;
            Description = desc;
        }

        [MethodImpl(Inline)]
        public EnumLiteral Untype()
            => new EnumLiteral(Order, Value, Description);


        [MethodImpl(Inline)]
        public static implicit operator EnumLiteral(EnumLiteral<T> src)
            => src.Untype();
    }
}