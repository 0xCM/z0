//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SM = AsmSyntaxMeaning;

    public enum AsmOpCodeToken : byte
    {
        None,

        /// <summary>
        /// <see cref='SM.Rd0'/>
        /// </summary>
        [Symbol("/0", SM.Rd0)]
        Rd0,

        /// <summary>
        /// <see cref='SM.Rd1'/>
        /// </summary>
        [Symbol("/1", SM.Rd1)]
        Rd1,

        /// <summary>
        /// <see cref='SM.Rd2'/>
        /// </summary>
        [Symbol("/2", SM.Rd2)]
        Rd2,

        /// <summary>
        /// <see cref='SM.Rd3'/>
        /// </summary>
        [Symbol("/3", SM.Rd3)]
        Rd3,

        /// <summary>
        /// <see cref='SM.Rd4'/>
        /// </summary>
        [Symbol("/4", SM.Rd4)]
        Rd4,

        /// <summary>
        /// <see cref='SM.Rd5'/>
        /// </summary>
        [Symbol("/5", SM.Rd5)]
        Rd5,

        /// <summary>
        /// <see cref='SM.Rd6'/>
        /// </summary>
        [Symbol("/6", SM.Rd6)]
        Rd6,

        /// <summary>
        /// <see cref='SM.Rd7'/>
        /// </summary>
        [Symbol("/7", SM.Rd7)]
        Rd7,

        [Symbol("VEX")]
        Vex,

        [Symbol("REX.W")]
        RexW,

        /// <summary>
        /// <see cref='SM.cb'/>
        /// </summary>
        [Symbol("cb", SM.cb)]
        Cb,

        /// <summary>
        /// <see cref='SM.cw'/>
        /// </summary>
        [Symbol("cw", SM.cw)]
        Cw,

        /// <summary>
        /// <see cref='SM.cd'/>
        /// </summary>
        [Symbol("cd", SM.cd)]
        Cd,

        /// <summary>
        /// <see cref='SM.cp'/>
        /// </summary>
        [Symbol("cp", SM.cp)]
        Cp,

        /// <summary>
        /// <see cref='SM.co'/>
        /// </summary>
        [Symbol("co", SM.co)]
        Co,

        /// <summary>
        /// <see cref='SM.ct'/>
        /// </summary>
        [Symbol("ct", SM.ct)]
        Ct,

        /// <summary>
        /// <see cref='SM.ib'/>
        /// </summary>
        [Symbol("ib", SM.ib)]
        Ib,

        /// <summary>
        /// <see cref='SM.iw'/>
        /// </summary>
        [Symbol("iw", SM.iw)]
        Iw,

        /// <summary>
        /// <see cref='SM.Id'/>
        /// </summary>
        [Symbol("id", SM.id)]
        Id,

        /// <summary>
        /// <see cref='SM.io'/>
        /// </summary>
        [Symbol("io", SM.io)]
        Io,

        /// <summary>
        /// <see cref='SM.ᕀrb'/>
        /// </summary>
        [Symbol("+rb",SM.ᕀrb)]
        Rb,

        /// <summary>
        /// <see cref='SM.ᕀrw'/>
        /// </summary>
        [Symbol("+rw", SM.ᕀrw)]
        Rw,

        /// <summary>
        /// <see cref='SM.ᕀrd'/>
        /// </summary>
        [Symbol("+rd",SM.ᕀrd)]
        Rd,

        /// <summary>
        /// <see cref='SM.ᕀro'/>
        /// </summary>
        [Symbol("+ro",SM.ᕀro)]
        Ro,
    }
}