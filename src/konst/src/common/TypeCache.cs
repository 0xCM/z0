//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a cache over a parametric closure
    /// </summary>
    public struct TypeCache<T>
        where T : new()
    {
        static T _Data = new T();

        [MethodImpl(Inline)]
        public TypeCache(in T src)
            => _Data = src;

        public ref readonly T Data
        {
            [MethodImpl(Inline)]
            get => ref _Data;
        }
    }
}