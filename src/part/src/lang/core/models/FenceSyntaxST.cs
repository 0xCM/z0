//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;
    /*
        Represents an expression of the form <LeftFence><FirstValue><Delimiter><LastValue><RightFence>
    */
    public readonly struct FenceSyntax<S,T> : ISyntax<FenceSyntax<S,T>>
        where S : unmanaged
    {
        public S LeftFence {get;}

        public T FirstValue {get;}

        public S Delimiter {get;}

        public T LastValue {get;}

        public S RightFence {get;}

        public FenceSyntax(Pair<S> fence, Pair<T> bounds, S delimiter)
        {
            LeftFence = fence.Left;
            RightFence = fence.Right;
            Delimiter = delimiter;
            FirstValue = bounds.Left;
            LastValue = bounds.Right;
        }

        public string Format()
            => string.Format(RP.Adjacent6, LeftFence, FirstValue, Delimiter, LastValue, RightFence);

        public override string ToString()
            => Format();
    }
}