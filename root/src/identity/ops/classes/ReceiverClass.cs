//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    using static ArityClass;
    using static ExchangeClass;

    public enum ReceiverClass : ulong
    { 
        None = 0,

        /// <summary>
        /// An operation that accepts no arguments and has a void return type
        /// </summary>
        Sink0 = Nullary | Receiver,

       /// <summary>
       /// An operation that accepts one argument and has a void return type
       /// </summary>
        Sink1 = Unary | Receiver,

       /// <summary>
       /// An operation that accepts two arguments and has a void return type
       /// </summary>
        Sink2 = Binary | Receiver,

       /// <summary>
       /// An operation that accepts three arguments and has a void return type
       /// </summary>
        Sink3 = Ternary | Receiver,
        
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
    }
}