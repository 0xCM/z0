//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore; 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;

    /// <summary>
    /// Defines register characteristic classifiers
    /// </summary>
    [Flags]
    public enum RegisterAspect : uint
    {
        None = 0,
        
        /// <summary>
        /// Indicates that register content is not preserved across function calls, commonly referred to as "caller saved"
        /// </summary>
        /// <remarks>
        /// This means that if a procedure (the caller) modifies register content, the
        /// register's orginal value must be restored prior to the procedure's exit/return;
        /// </remarks>
        Unsaved = 1,

        /// <summary>
        /// Indicates that register content is preserved across function calls, commonly referred to as "callee saved"
        /// </summary>
        Saved = 2,

        /// <summary>
        /// Indicates a register contains a pointer to the top/leading stack element
        /// </summary>
        StackPointer = 4,

        /// <summary>
        /// Indicates that a register (by x86/windows calling convention), is used to supply an integral argument to a function
        /// </summary>
        ArgStore = 8,

        /// <summary>
        /// Indicates that a register (by x86/windows calling convention) is used to store a function return value
        /// </summary>
        ReturnStore = 16,
        
    }

    

}