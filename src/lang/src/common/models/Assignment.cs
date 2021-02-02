//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Assignment
    {
        public Variable Left {get;}

        public Variable Right {get;}

        [MethodImpl(Inline)]
        public Assignment(Variable lhs, Variable rhs)
        {
            Left = lhs;
            Right = rhs;
        }
    }

    /// <summary>
    /// Represents an assignment A := B
    /// </summary>
    public readonly struct Assignment<A,B>
    {
        public A Left {get;}

        public B Right {get;}

        [MethodImpl(Inline)]
        public Assignment(A left, B right)
        {
            Left = left;
            Right = right;
        }

        [MethodImpl(Inline)]
        public static implicit operator Assignment<A,B>(Paired<A,B> src)
            => new Assignment<A,B>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator Assignment<A,B>((A Left, B Right) src)
            => new Assignment<A,B>(src.Left, src.Right);
    }
}