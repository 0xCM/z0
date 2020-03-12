//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Root;
    using static ArityClass;

    public enum ActionClass : ulong
    { 
        None = 0,

        /// <summary>
        /// An operation that accepts no arguments and has a void return type
        /// </summary>
        Sink0 = Nullary | Action,

       /// <summary>
       /// An operation that accepts one argument and has a void return type
       /// </summary>
        Sink1 = Unary | Action,

       /// <summary>
       /// An operation that accepts two arguments and has a void return type
       /// </summary>
        Sink2 = Binary | Action,

       /// <summary>
       /// An operation that accepts three arguments and has a void return type
       /// </summary>
        Sink3 = Ternary | Action,
        
        /// <summary>
        /// A synonym for Sink0
        /// </summary>
        NullarySink = Sink0,

        /// <summary>
        /// A synonym for Sink1
        /// </summary>
        UnarySink = Sink1,

        /// <summary>
        /// A synonym for Sunc2
        /// </summary>
        BinarySink = Sink2,

        /// <summary>
        /// A synonym for Func3
        /// </summary>
        TernarySink = Sink3,

        Action = OperationClass.Action,    
    }



}