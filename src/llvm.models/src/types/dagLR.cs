//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm.types
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct dag
    {
        public static dag<ITerm> parse(string src)
        {
            var dag = new dag<ITerm>(@string.Empty, @string.Empty);
            if(src.Contains("->"))
            {
                var parts = src.SplitClean("->").Select(x => x.Trim());
                var count = parts.Length;
                var first = EmptyString;
                for(var i=0; i<count; i++)
                {
                    ref readonly var current = ref skip(parts,i);
                    if(i==0)
                        first = current;
                    else if(i==1)
                        dag = new dag<ITerm>((@string)first, (@string)current);
                    else
                        dag = new dag<ITerm>((@string)current, dag);
                }
            }
            else
            {
                dag = new dag<ITerm>((@string)src, @string.Empty);
            }
            return dag;
        }
    }

    public class dag<L,R> : IDag<L,R>
        where L : ITerm
        where R : ITerm
    {
        public L Left {get;}

        public R Right {get;}

        [MethodImpl(Inline)]
        public dag(L left, R right)
        {
            Left = left;
            Right = right;
        }

        public string Format()
        {
            if(Left.IsNonEmpty && Right.IsNonEmpty)
                return string.Format("arrow({0},{1})", Left.Format(), Right.Format());
            else if(Left.IsEmpty && Right.IsEmpty)
                return EmptyString;
            else if(Left.IsNonEmpty)
                return Left.Format();
            else
                return Right.Format();
        }

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator dag<L,R>((L left, R right) src)
            => new dag<L,R>(src.left, src.right);
    }
}