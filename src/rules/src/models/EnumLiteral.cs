//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct Rules
    {
        [StructLayout(LayoutKind.Sequential)]
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
}