//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial struct Rules
    {
        public readonly struct NonEmpty<T> : IRule<NonEmpty<T>,T>
        {

        }
    }
}