//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    /// <summary>
    /// Characterizes an identifier
    /// </summary>
    public interface IIdentified
    {        
        string Identifier {get;}

        bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Identifier);
        }               

        bool IsNonEmpty
        {            
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }
}