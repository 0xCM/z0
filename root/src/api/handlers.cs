//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Root
    {
        /// <summary>
        /// Executes an action if condition is false
        /// </summary>
        /// <param name="condition">Specifies whether some condition is true</param>
        /// <param name="@false">The action to invoke when condition is false</param>
        [MethodImpl(Inline)]
        public static void onFalse(bool condition, Action @false)
        {
            if(!condition)
                @false();
        }

        /// <summary>
        /// Executes an action if condition is true
        /// </summary>
        /// <param name="condition">Specifies whether some condition is true</param>
        /// <param name="@false">The action to invoke when condition is false</param>
        [MethodImpl(Inline)]
        public static void onTrue(bool condition, Action @true)
        {
            if(condition)
                @true();
        }
    }
}