//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct StringIndex
    {
        public Index<uint> Keys {get;}

        public Index<TextBlock> Values {get;}

        [MethodImpl(Inline)]
        public StringIndex(uint[] keys, Index<TextBlock> blocks)
        {
            Keys = keys;
            Values = blocks;
        }

        public ref TextBlock this[uint key]
        {
            [MethodImpl(Inline)]
            get => ref Values[key];
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Keys.Length;
        }
    }
}