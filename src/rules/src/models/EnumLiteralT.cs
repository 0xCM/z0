//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Z0.Lang;

    using static Root;

    partial struct Rules
    {

        [StructLayout(LayoutKind.Sequential)]
        public struct EnumLiteral<T>
        {
            /// <summary>
            /// The literal's declaration order
            /// </summary>
            public uint Order;

            public Literal<T> Value;

            public string Description;

            [MethodImpl(Inline)]
            public EnumLiteral(uint order, Literal<T> value, string desc)
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
}