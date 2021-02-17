//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct RP
    {
        /// <summary>
        /// Defines the canonical setting format
        /// </summary>
        [RenderPattern(2, Assign)]
        public const string Assign = "{0}={1}";
    }
}