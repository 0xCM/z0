//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.CompilerServices;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public readonly struct PeReaderEvents
    {
        const string NoMagicDescription ="Magic is not here";        

        public static AppEvent NoMagic([Caller] string caller = null) 
            => new AppEvent(EventId.define("NoMagic", caller), NoMagicDescription, AppMsgColor.Red);
    }
}