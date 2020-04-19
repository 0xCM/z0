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

    public static class HexParsers
    {
        /// <summary>
        /// The default hex byte parser service
        /// </summary>
        public static HexByteParser Bytes
        {
            [MethodImpl(Inline)]
            get => default(HexByteParser);
        }

        /// <summary>
        /// The default hex numeric parser service
        /// </summary>
        public static HexNumericParser Numeric
        {
            [MethodImpl(Inline)]
            get => default(HexNumericParser);
        }

        /// <summary>
        /// The default memory range parser service
        /// </summary>
        public static IParser<MemoryRange> MemoryRange
        {
            [MethodImpl(Inline)]
            get => default(MemoryRangeParser);
        }
    }
}