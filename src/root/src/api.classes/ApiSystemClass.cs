//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiClass]
    public enum ApiSystemClass : ushort
    {
        None = 0,

        /// <summary>
        /// Identifies operations that initialize a resource where allocation may be required...or not
        /// </summary>
        Init = ApiClass.Init,

        /// <summary>
        /// Identifies operations assign kind classifiers
        /// </summary>
        Kind = ApiClass.Kind
    }
}