//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;


    public static class LogicMachine
    {


    }

    public ref struct LogicMachine<S,I,O>
        where I : unmanaged
        where O : unmanaged
        where S : unmanaged
    {
        Stacked<S> stack;

        RingBuffer<I> input;

        RingBuffer<O> output;

    }


}