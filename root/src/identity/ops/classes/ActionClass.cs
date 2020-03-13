//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static ArityClass;

    public enum ActionClass : ulong
    { 
        None = 0,

        /// <summary>
        /// An operation that accepts no arguments and has a void return type
        /// </summary>
        Act0 = Nullary | Action,

       /// <summary>
       /// An operation that accepts one argument and has a void return type
       /// </summary>
        Act1 = Unary | Action,

       /// <summary>
       /// An operation that accepts two arguments and has a void return type
       /// </summary>
        Act2 = Binary | Action,

       /// <summary>
       /// An operation that accepts three arguments and has a void return type
       /// </summary>
        Act3 = Ternary | Action,
        

        Action = Pow2.T55,    
    }
}