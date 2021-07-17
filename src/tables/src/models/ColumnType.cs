//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ColumnType
    {
        public string Name {get;}

        [MethodImpl(Inline)]
        public ColumnType(string name)
        {
            Name = name;
        }

        [MethodImpl(Inline)]
        public static implicit operator ColumnType(string name)
            => new ColumnType(name);
    }
}