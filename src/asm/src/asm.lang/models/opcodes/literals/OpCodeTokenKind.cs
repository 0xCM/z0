//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using M = AsmSyntaxMeaning;

    /// <summary>
    ///
    /// </summary>
    public enum OpCodeTokenKind : byte
    {
        None,

        /// <summary>
        /// <see cref='M.Rd0'/>
        /// </summary>
        Rd0,

        /// <summary>
        /// <see cref='M.Rd1'/>
        /// </summary>
        Rd1,

        /// <summary>
        /// <see cref='M.Rd2'/>
        /// </summary>
        Rd2,

        /// <summary>
        /// <see cref='M.Rd3'/>
        /// </summary>
        Rd3,

        /// <summary>
        /// <see cref='M.Rd4'/>
        /// </summary>
        Rd4,

        /// <summary>
        /// <see cref='M.Rd5'/>
        /// </summary>
        Rd5,

        /// <summary>
        /// <see cref='M.Rd6'/>
        /// </summary>
        Rd6,

        /// <summary>
        /// <see cref='M.Rd7'/>
        /// </summary>
        Rd7,

        Vex,

        Rex,

        Evex,

        Lig,

        x128,

        x256,

        Nds,


        /// <summary>
        /// <see cref='M.Cb'/>
        /// </summary>
        Cb,

        /// <summary>
        /// <see cref='M.Cw'/>
        /// </summary>
        Cw,

        /// <summary>
        /// <see cref='M.Cd'/>
        /// </summary>
        Cd,

        /// <summary>
        /// <see cref='M.Cp'/>
        /// </summary>
        Cp,

        /// <summary>
        /// <see cref='M.Co'/>
        /// </summary>
        Co,

        /// <summary>
        /// <see cref='M.Ct'/>
        /// </summary>
        Ct,

        /// <summary>
        /// <see cref='M.Ib'/>
        /// </summary>
        Ib,

        /// <summary>
        /// <see cref='M.Iw'/>
        /// </summary>
        Iw,

        /// <summary>
        /// <see cref='M.Id'/>
        /// </summary>
        Id,

        /// <summary>
        /// <see cref='M.Io'/>
        /// </summary>
        Io,

        Rb,

        Rw,

    }
}