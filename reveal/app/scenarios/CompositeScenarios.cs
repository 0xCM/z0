//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using static zfunc;


    
    class CompositeScenarios : Deconstructable<CompositeScenarios>
    {
        public CompositeScenarios()
            : base(callerfile())
        {

        }

        public static void loop(int count, Action<int> callee)
        {
            for(var i=0; i<count; i++)
                callee(i);
        }

        public static void swap8u(ref byte x, ref byte y)
        {
            var tmp = x;
            x = y;
            y = tmp;
        }

        public static void swap32i(ref int x, ref int y)
        {
            var tmp = x;
            x = y;
            y = tmp;
        }

    }

}