//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines an item selection
    /// </summary>
    public readonly struct Choice<T> : IChoice<Choice<T>,T>
    {
        public T Chosen {get;}

        [MethodImpl(Inline)]
        public Choice(T chosen)
            => Chosen = chosen;

        [MethodImpl(Inline)]
        public static implicit operator Choice<T>(T src)
            => new Choice<T>(src);
    }
}