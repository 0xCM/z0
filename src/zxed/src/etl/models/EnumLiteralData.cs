//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

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
            this.Index = index;
            Name = name;
            Description = description;
        }
    }
}