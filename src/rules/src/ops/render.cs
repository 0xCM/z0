//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Rules
    {
        public static void render<F,C>(Enclosed<F,C> rule, ITextBuffer dst)
            => dst.AppendFormat("{0}{1}{2}", rule.Fence.Left, rule.Content, rule.Fence.Right);
    }
}