//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Rules
    {
        public interface ITerm : ITextual
        {

        }

        public interface ITerm<T> : ITerm
        {
        }
    }
}