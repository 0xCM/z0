//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct NamedRegValue<T>
        where T : unmanaged
    {
        public RegName Name {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public NamedRegValue(RegName name, T value)
        {
            Name = name;
            Value = value;
        }

        public string Format()
            => AsmRender.format(this);

        // public string FormatBits()
        // {

        // }

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator NamedRegValue<T>(Paired<RegName,T> src)
            => @as<Paired<RegName,T>,NamedRegValue<T>>(src);
    }
}