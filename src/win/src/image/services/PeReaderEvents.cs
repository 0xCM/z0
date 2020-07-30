//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct PeReaderEvents
    {
        const string NoMagicDescription ="Magic is not here";        

        public static AppEvent NoMagic() 
            => new AppEvent(nameof(NoMagic), NoMagicDescription, AppMsgColor.Red);
    }
}