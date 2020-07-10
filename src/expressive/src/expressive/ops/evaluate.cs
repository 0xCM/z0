//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;

    using static Konst;

    partial class XPress
    {
        public static NamedValue<T> evaluate<T>(Expression<Func<T>> fx)
        {
            var name = fx.AccessedMember().MapValueOrElse(x => x.Name, () => "?");
            var value = fx.Compile().Invoke();
            return (name, value);
        }

        public static Option<object> evaluate(Expression x)
        {
            var value = XQuery.constant(x);
            if (!value)
            {
                var N = (x as NewExpression);
                if (N != null)
                {
                    var args = N.Arguments.Select(a => XQuery.constant(a).ValueOrDefault()).ToArray();
                    value = Activator.CreateInstance(N.Type, args);
                }
            }
            return value;
        }

        public static Option<object> evaluate(BinaryExpression x)
            => evaluate(x.Left).ValueOrElse(() => evaluate(x.Right));
    }
}