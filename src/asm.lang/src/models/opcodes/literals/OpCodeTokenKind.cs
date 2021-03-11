//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
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
        /// <see cref='M.cb'/>
        /// </summary>
        Cb,

        /// <summary>
        /// <see cref='M.cw'/>
        /// </summary>
        Cw,

        /// <summary>
        /// <see cref='M.cd'/>
        /// </summary>
        Cd,

        /// <summary>
        /// <see cref='M.cp'/>
        /// </summary>
        Cp,

        /// <summary>
        /// <see cref='M.co'/>
        /// </summary>
        Co,

        /// <summary>
        /// <see cref='M.ct'/>
        /// </summary>
        Ct,

        /// <summary>
        /// <see cref='M.ib'/>
        /// </summary>
        Ib,

        /// <summary>
        /// <see cref='M.iw'/>
        /// </summary>
        Iw,

        /// <summary>
        /// <see cref='M.Id'/>
        /// </summary>
        Id,

        /// <summary>
        /// <see cref='M.io'/>
        /// </summary>
        Io,

        /// <summary>
        /// <see cref='M.ᕀrb'/>
        /// </summary>
        Rb,

        /// <summary>
        /// <see cref='M.ᕀrw'/>
        /// </summary>
        Rw,

        /// <summary>
        /// <see cref='M.ᕀrd'/>
        /// </summary>
        Rd,

        /// <summary>
        /// <see cref='M.ᕀro'/>
        /// </summary>
        Ro,
    }
}