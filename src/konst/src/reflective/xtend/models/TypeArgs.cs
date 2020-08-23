//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TypeArgs
    {
        public readonly TypeArg[] Storage;

        [MethodImpl(Inline)]
        public TypeArgs(TypeArg[] args)
            => Storage = args;

        public ref TypeArg this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Storage[index];
        }

        public CellCount Count
        {
            [MethodImpl(Inline)]
            get => Storage.Length;
        }
    }
}