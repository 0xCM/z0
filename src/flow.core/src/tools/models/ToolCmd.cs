//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public readonly struct ToolCmd : IToolCmd
    {
        public ToolId ToolId {get;}

        public string[] Args {get;}

        public KeyedValues<string,string> Options {get;}

        public ToolCmd(ToolId id, string[] args, params KeyedValue<string,string>[] options)
        {
            ToolId = id;
            Args = args;
            Options = new KeyedValues<string,string>(options);
        }
    }   
}
