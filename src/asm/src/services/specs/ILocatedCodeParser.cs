//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ILocatedCodeParser : IService
    {
        /// <summary>
        /// Located code in, and perhaps, located code out
        /// </summary>
        /// <param name="src">The code to parse</param>
        Option<LocatedCode> Parse(LocatedCode src);        
    }
}