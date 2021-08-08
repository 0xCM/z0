//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Blit;

    public readonly struct JccInfo<K>
        where K : unmanaged
    {
        public K Kind {get;}

        public name64 Name {get;}

        public AsmSize Size {get;}

        [MethodImpl(Inline)]
        public JccInfo(K kind, name64 name, AsmSize size)
        {
            Name = name;
            Size = size;
            Kind = kind;
        }

        public byte Encoding
        {
            [MethodImpl(Inline)]
            get => u8(Kind);
        }
    }
}