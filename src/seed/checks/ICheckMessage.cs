//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Text;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;

    public interface ICheckMessage
    {
        void Print(IAppMsg message)
            => Terminal.Get().WriteMessage(message);
    }
}