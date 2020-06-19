//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
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

    public interface IIdentified<T> : IIdentified
        where T : IIdentification
    {
        T Id {get;}

        string IIdentified.Identifier 
            => Id.Identifier;
    }
}