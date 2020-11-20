//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct Interpreter
    {
        public readonly struct Command
        {
            public string Name {get;}

            public string Description {get;}
        }

        public readonly struct CommandOption
        {
            public string Name {get;}

            public string Description {get;}
        }
    }
}