//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class CommandSystemSettings : ProvidedConfiguration<CommandSystemSettings>
    {
        public CommandSystemSettings(IConfigurationProvider provider)
            : base(provider)
        { }

        public FolderPath CommandFolder
            => GetThisSetting(FolderPath.Parametric(@"$(FileLib)\commands"), true);       
    }
}