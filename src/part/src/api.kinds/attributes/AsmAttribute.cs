//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Identifies a formal operation and its kind
    /// </summary>
    public class AsmAttribute : OpAttribute
    {
        public AsmAttribute(AsmApiKey key)
        {
            Key = key;
        }

        public AsmApiKey Key {get;}
    }
}