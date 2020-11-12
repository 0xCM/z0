//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfArg<T>
    {
        public string Name {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public WfArg(string name, T value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator WfArg<T>((string name, T value) src)
            => new WfArg<T>(src.name, src.value);

        [MethodImpl(Inline)]
        public static implicit operator WfArg(WfArg<T> src)
            => new WfArg(src.Name, src.Value?.ToString() ?? "");

        public static WfArg<T> Empty
            => new WfArg<T>("", default(T));
    }
}