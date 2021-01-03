//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Strings;

    public readonly struct StringIndex
    {
        internal readonly uint[] Keys;

        internal readonly string[] Values;

        [MethodImpl(Inline)]
        internal StringIndex(uint[] keys, string[] values)
        {
            Keys = keys;
            Values = values;
        }

        [MethodImpl(Inline)]
        public bool Value(uint key, out string value)
            => api.value(this, key, out value);

        public string this[uint key]
        {
            [MethodImpl(Inline)]
            get => api.value(this, key);
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Keys.Length;
        }
    }
}