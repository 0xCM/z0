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
        string IdentityText {get;}

        bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(IdentityText);
        }               

        bool IsNonEmpty
        {            
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }

    public interface IIdentified<T> : IIdentified
        where T : IIdentification
    {
        T Id {get;}

        string IIdentified.IdentityText => Id.IdentityText;
    }
}