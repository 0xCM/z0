//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes an identifier
    /// </summary>
    public interface IIdentified
    {        
        string Identifier {get;}

        bool IsEmpty 
            => string.IsNullOrWhiteSpace(Identifier);

        bool IsNonEmpty
            => !IsEmpty;

    }

    public interface IIdentified<T> : IIdentified
    {
        T Id {get;}

        string IIdentified.Identifier 
            => $"{Id}";
    }
}