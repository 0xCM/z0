//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public enum ReceiverKind : ulong
    { 
        None = 0,

        /// <summary>
        /// An operation that accepts no arguments and has a void return type
        /// </summary>
        Sink0 = Pow2.T00,

       /// <summary>
       /// An operation that accepts one argument and has a void return type
       /// </summary>
        Sink1 = Pow2.T01,

       /// <summary>
       /// An operation that accepts two arguments and has a void return type
       /// </summary>
        Sink2 = Pow2.T02,

       /// <summary>
       /// An operation that accepts three arguments and has a void return type
       /// </summary>
        Sink3 = Pow2.T03,

       /// <summary>
       /// An operation that accepts four arguments and has a void return type
       /// </summary>
        Sink4 = Pow2.T04,

       /// <summary>
       /// An operation that accepts five arguments and has a void return type
       /// </summary>
        Sink5 = Pow2.T05,
        
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