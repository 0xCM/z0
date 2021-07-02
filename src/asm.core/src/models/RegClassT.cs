//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

   public readonly struct RegClass<T> : IRegClass<T>
        where T : unmanaged, IRegClass<T>
    {
        public RegClassCode Kind
        {
            [MethodImpl(Inline)]
            get => Class.Kind;
        }

        public T Class {get;}

        [MethodImpl(Inline)]
        public RegClass(T @class)
        {
            Class = @class;
        }

        public static implicit operator RegClass<T>(T src)
            => new RegClass<T>();
    }
}