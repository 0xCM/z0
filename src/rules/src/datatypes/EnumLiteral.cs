//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct EnumLiteral
    {
        /// <summary>
        /// The literal's declaration order
        /// </summary>
        public uint Order;

        public Literal Value;

        public string Description;

        [MethodImpl(Inline)]
        public EnumLiteral(uint order, Literal value, string desc)
        {
            Order = order;
            Value = value;
            Description = desc;
        }
    }
}