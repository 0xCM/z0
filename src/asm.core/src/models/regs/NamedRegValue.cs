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

    public readonly struct NamedRegValue<T>
        where T : unmanaged
    {
        public text7 Name {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public NamedRegValue(text7 name, T value)
        {
            Name = name;
            Value = value;
        }

        public string Format()
            => AsmRegs.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator NamedRegValue<T>(Paired<text7,T> src)
            => @as<Paired<text7,T>,NamedRegValue<T>>(src);
    }
}