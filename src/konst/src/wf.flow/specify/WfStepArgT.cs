//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct WfStepArg<T>: IWfStepArg<T>, ITextual
        where T : ITextual
    {
        public string Name {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator WfStepArg<T>((string name, T value) src)
            => new WfStepArg<T>(src.name, src.value);

        [MethodImpl(Inline)]
        public WfStepArg(string name, T value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Value.Format();
    }
}