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

    [ApiHost]
    public static partial class DXTend
    {

    }

    [ApiHost]
    public partial class Delegates
    {
        /// <summary>
        /// Creates an action delegate from a method
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline), Op]
        public static Action action(MethodInfo src, object host)
            => from<Action>(src, host);

        /// <summary>
        /// Creates an action delegate from a method
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline), Op]
        public static Action action(MethodInfo src)
            => from<Action>(src);

        /// <summary>
        /// Infers a delegate type compatible with the signature of a specified method
        /// </summary>
        /// <param name="src">The source method</param>
        public static Type type(MethodInfo src)
        {
            var args = src.ParameterTypes();
            return src.IsAction()
                ? Expression.GetActionType(args)
                : Expression.GetFuncType(z.concat(args, z.array(src.ReturnType)));
        }
    }
}