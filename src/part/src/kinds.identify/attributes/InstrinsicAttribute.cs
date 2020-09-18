//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Identifies a formal operation and its kind
    /// </summary>
    public abstract class IntrinsicAttribute : OpAttribute
    {
        protected IntrinsicAttribute(IntrinsicApiKey key)
        {
            Key = key;
        }

        public IntrinsicApiKey Key {get;}
    }
}