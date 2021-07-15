//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Rules
    {
        public unsafe readonly struct Primitives
        {

        }

        internal class PrimalData
        {
            [FixedAddressValueType]
            static Index<uint> Keys;

            [FixedAddressValueType]
            static Index<CharBlock16> Names;

            static long Pos;

            const byte Capacity = 255;

            static PrimalData()
            {
                Keys = core.alloc<uint>(Capacity);
                Names = core.alloc<CharBlock16>(Capacity);
            }

            internal static Primitive define(uint key, string name)
            {
                Keys[Pos] = key;
                Names[Pos] = name;
                inc(ref Pos);
                return new Primitive(key);
            }
        }

    }
}