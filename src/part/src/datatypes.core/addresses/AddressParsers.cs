//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AddressParsers
    {
        public static void include(ParseFunctions dst)
        {
            dst.Include(MemoryAddress);
            dst.Include(Address64);
            dst.Include(Address32);
            dst.Include(Address16);
            dst.Include(Address8);
        }

        public static ParseFunction<MemoryAddress> MemoryAddress
            => Addresses.parse;

        public static ParseFunction<Address64> Address64
            => Addresses.parse;

        public static ParseFunction<Address32> Address32
            => Addresses.parse;

        public static ParseFunction<Address16> Address16
            => Addresses.parse;

        public static ParseFunction<Address8> Address8
            => Addresses.parse;
    }
}