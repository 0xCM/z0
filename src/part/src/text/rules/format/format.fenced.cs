//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;
    using static memory;
    using static Rules;

    partial struct TextRules
    {
        partial struct Format
        {
            public static string format<F,C>(Fenced<F,C> rule)
            {
                var buffer = text.buffer();
                render(rule,buffer);
                return buffer.Emit();
            }

            public static void render<F,C>(Fenced<F,C> rule, ITextBuffer dst)
                => dst.AppendFormat("{0}{1}{2}", rule.Fence.Left, rule.Content, rule.Fence.Right);

            public static string format<T>(Join<T> rule)
            {
                var buffer = text.buffer();
                render(rule, buffer);
                return buffer.Emit();
            }

            public static void render<T>(Join<T> rule, ITextBuffer dst)
                => string.Join(rule.Delimiter, rule.Terms);
        }
    }
}