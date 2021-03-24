//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using OCD = AsmOpCodeDocs;

    [SymbolSource]
    public enum AsmOpCodeToken : byte
    {
        None,

        /// <summary>
        /// <see cref='OCD.r'/>
        /// </summary>
        [Symbol("/r", OCD.r)]
        r,

        /// <summary>
        /// <see cref='OCD.r0'/>
        /// </summary>
        [Symbol("/0", OCD.r0)]
        r0,

        /// <summary>
        /// <see cref='OCD.r1'/>
        /// </summary>
        [Symbol("/1", OCD.r1)]
        r1,

        /// <summary>
        /// <see cref='OCD.r2'/>
        /// </summary>
        [Symbol("/2", OCD.r2)]
        r2,

        /// <summary>
        /// <see cref='OCD.r3'/>
        /// </summary>
        [Symbol("/3", OCD.r3)]
        r3,

        /// <summary>
        /// <see cref='OCD.r4'/>
        /// </summary>
        [Symbol("/4", OCD.r4)]
        r4,

        /// <summary>
        /// <see cref='OCD.r5'/>
        /// </summary>
        [Symbol("/5", OCD.r5)]
        r5,

        /// <summary>
        /// <see cref='OCD.r6'/>
        /// </summary>
        [Symbol("/6", OCD.r6)]
        r6,

        /// <summary>
        /// <see cref='OCD.r7'/>
        /// </summary>
        [Symbol("/7", OCD.r7)]
        r7,

        [Symbol("VEX")]
        Vex,

        [Symbol("REX.W")]
        RexW,

        /// <summary>
        /// <see cref='OCD.cb'/>
        /// </summary>
        [Symbol("cb", OCD.cb)]
        cb,

        /// <summary>
        /// <see cref='OCD.cw'/>
        /// </summary>
        [Symbol("cw", OCD.cw)]
        cw,

        /// <summary>
        /// <see cref='OCD.cd'/>
        /// </summary>
        [Symbol("cd", OCD.cd)]
        cd,

        /// <summary>
        /// <see cref='OCD.cp'/>
        /// </summary>
        [Symbol("cp", OCD.cp)]
        cp,

        /// <summary>
        /// <see cref='OCD.co'/>
        /// </summary>
        [Symbol("co", OCD.co)]
        co,

        /// <summary>
        /// <see cref='OCD.ct'/>
        /// </summary>
        [Symbol("ct", OCD.ct)]
        ct,

        /// <summary>
        /// <see cref='OCD.ib'/>
        /// </summary>
        [Symbol("ib", OCD.ib)]
        ib,

        /// <summary>
        /// <see cref='OCD.iw'/>
        /// </summary>
        [Symbol("iw", OCD.iw)]
        iw,

        /// <summary>
        /// <see cref='OCD.Id'/>
        /// </summary>
        [Symbol("id", OCD.id)]
        id,

        /// <summary>
        /// <see cref='OCD.io'/>
        /// </summary>
        [Symbol("io", OCD.io)]
        io,

        /// <summary>
        /// <see cref='OCD.ᕀrb'/>
        /// </summary>
        [Symbol("+rb",OCD.ᕀrb)]
        rb,

        /// <summary>
        /// <see cref='OCD.ᕀrw'/>
        /// </summary>
        [Symbol("+rw", OCD.ᕀrw)]
        rw,

        /// <summary>
        /// <see cref='OCD.ᕀrd'/>
        /// </summary>
        [Symbol("+rd",OCD.ᕀrd)]
        rd,

        /// <summary>
        /// <see cref='OCD.ᕀro'/>
        /// </summary>
        [Symbol("+ro",OCD.ᕀro)]
        ro,

        /// <summary>
        /// <see cref='OCD.ᕀrq'/>
        /// </summary>
        [Symbol("+ro",OCD.ᕀrq)]
        rq,
    }
}