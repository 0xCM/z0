//-----------------------------------------------------------------------------
// Copyright   : (c) Chris Moore, 2020
// License     : MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EnumLiteralData
    {
        public readonly int Index;

        public readonly string Name;

        public readonly string Description;

        [MethodImpl(Inline)]
        public EnumLiteralData Define(int index, string name, string description)
            => new EnumLiteralData(index, name, description);

        [MethodImpl(Inline)]
        public EnumLiteralData(int index, string name, string description)
        {
            Index = index;
            Name = name;
            Description = description;
        }
    }
}