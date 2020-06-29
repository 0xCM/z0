//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    public interface IRenderedAsci : IAsciSequence
    {
        /// <summary>
        /// The sequence content rendered as text
        /// </summary>
        string Text {get;}

        /// <summary>
        /// The sequence prasented as a decoded character span
        /// </summary>
        ReadOnlySpan<char> Decoded
            => Text;
        
        string ITextual.Format()
            => Text;
    }
}