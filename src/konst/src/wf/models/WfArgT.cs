//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct WfArg<T>
    {
        public readonly string Name;

        public readonly T Value;

        [MethodImpl(Inline)]
        public static implicit operator WfArg<T>((string name, T value) src)
            => new WfArg<T>(src.name, src.value);

        [MethodImpl(Inline)]
        public static implicit operator WfArg(WfArg<T> src)
            => new WfArg(src.Name, src.Value?.ToString() ?? "");

        [MethodImpl(Inline)]
        public WfArg(string name, T value)
        {
            Name = name;
            Value = value;
        }

        public static WfArg<T> Empty
            => new WfArg<T>("", default(T));
    }
}