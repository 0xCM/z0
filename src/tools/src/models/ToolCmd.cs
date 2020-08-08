//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public struct ToolCmd<T,F> : IToolCmd<T,F>
        where T : struct, ITool<T,F>
        where F : unmanaged, Enum
    {
        public readonly string[] Args;

        public readonly KeyedValues<F,string> Options;
        
        [MethodImpl(Inline)]
        public ToolCmd(string[] args, params KeyedValue<F,string>[] options)
        {
            Args = args;
            Options = new KeyedValues<F, string>(options);
        }
    }   
}
