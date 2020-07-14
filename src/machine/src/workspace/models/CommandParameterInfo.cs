//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class CommandParameterInfo
    {
        public string ParameterName { get; }

        public DataMember Accessor { get; }

        public CommandParameterInfo(string ParameterName, DataMember Accessor)
        {
            this.ParameterName = ParameterName;
            this.Accessor = Accessor;
        }
    }
}