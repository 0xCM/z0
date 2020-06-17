//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a signable thing
    /// </summary>
    public interface ISigned
    {
        /// <summary>
        /// The sign of the signable thing
        /// </summary>
        SignKind Sign {get;}
    }
    
    /// <summary>
    /// Characterizes a signable reification
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    public interface ISigned<F> : ISigned
        where F : ISigned<F>, new()
    {
    
    }
}