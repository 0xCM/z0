//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;

    public class MachineConfig : AppSettings<MachineConfig>
    {
        public override string ToString()
            => ((IAppSettingsProvider)this).Format();

        public bool Flag1 {get; set;}

        public bool Flag2 {get; set;}

        public int Setting1 {get; set;}
    }
}