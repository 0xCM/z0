//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Linq.Expressions;

    using static Konst;
    using static Control;

    public static partial class Delegates
    {
        /// <summary>
        /// Creates an action delegate from a method
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        public static Action action(MethodInfo src, object host = null)
            => create<Action>(src, host);

        /// <summary>
        /// Infers a delegate type compatible with the signature of a specified methods
        /// </summary>
        /// <param name="src">The source method</param>
        public static Type type(MethodInfo src)
        {
            var args = src.ParameterTypes().ToArray();
            return src.IsAction()
                ? Expression.GetActionType(args)
                : Expression.GetFuncType(concat(args, array(src.ReturnType)));
        }
    }
}