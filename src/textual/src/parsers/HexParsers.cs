//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    
    using static Seed;

    public class HexParsers
    {
        public static IHexParser<byte> Bytes => HexByteParser.Service;

        public static IParametricParser Numeric => HexNumericParser.Service;

        public static IParser<MemoryAddress> MemoryAddress => MemoryAddressParser.Service;

        public static HexScalarParser Scalar => HexScalarParser.Service;

        public static IParser<MemoryRange> MemoryRange => MemoryRangeParser.Service;
    }
}