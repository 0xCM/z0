//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static Root;

    public enum AsmShellCmdKind : byte
    {
        [CmdSpec(EmptyString, EmptyString)]
        None = 0,

        [CmdSpec(".exit", "Terminates the shell")]
        Exit,

        [CmdSpec(".processor","Queries for the executing processor")]
        Processor,

        [CmdSpec(".help","Produces shell help")]
        Help,

        [CmdSpec(".registers","Shows register information")]
        Registers,

        [CmdSpec(".demos","Executes random examples")]
        Demos,


        [CmdSpec(".exec","Executes enqueued code")]
        Exec,
    }
}