//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct CmdOptionInfo
    {
        public string OptionId {get;}

        public string OptionName {get;}

        public string Description {get;}

        [MethodImpl(Inline)]
        public CmdOptionInfo(string id, string name, string info)
        {
            OptionId = id;
            OptionName = name;
            Description = info;
        }

        public string Format()
            => string.Format("{0}:{1}", OptionName, Description);

        public override string ToString()
            => Format();
    }
}