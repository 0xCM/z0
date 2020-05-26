//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    /// <summary>
    /// Defines appendix reference component values
    /// </summary>
    [FieldComponent(typeof(DocField))]
    public enum Appendix : byte
    {        
        /// <summary>
        /// Appendix A
        /// </summary>
        AppendixA = (byte)'A',

        /// <summary>
        /// Appendix B
        /// </summary>
        AppendixB = (byte)'B',

        /// <summary>
        /// Appendix C
        /// </summary>
        AppendixC = (byte)'C',

        /// <summary>
        /// Appendix D
        /// </summary>
        AppendixD  = (byte)'D',

        /// <summary>
        /// Appendix E
        /// </summary>
        AppendixE  = (byte)'E',

        /// <summary>
        /// Appendix F
        /// </summary>
        AppendixF = (byte)'F',

        /// <summary>
        /// Appendix G
        /// </summary>
        AppendixG  = (byte)'G',
    }
}