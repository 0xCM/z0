//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    public struct AsmWorkerState<T>
    {
        T[] Current;

        List<IAsmOpererands> Operands;

        public ref readonly T View
        {
            [MethodImpl(Inline)]
            get => ref Current[0];
        }

        public ref T Edit
        {
            [MethodImpl(Inline)]
            get => ref Current[0];
        }

        [MethodImpl(Inline)]
        public AsmWorkerState(T state, params IAsmOpererands[] operands)
        {
            Current = new T[1]{state};
            Operands = operands.ToList();
        }

        [MethodImpl(Inline)]
        public void Handled(IAsmOpererands cmd)
            => Operands.Add(cmd);
    }
}