//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SD = AsmSyntaxDocs;

    [SymbolSource]
    public enum AsmOpCodeToken : byte
    {
        None,

        /// <summary>
        /// <see cref='SD.r'/>
        /// </summary>
        [Symbol("/r", SD.r)]
        r,

        /// <summary>
        /// <see cref='SD.r0'/>
        /// </summary>
        [Symbol("/0", SD.r0)]
        r0,

        /// <summary>
        /// <see cref='SD.r1'/>
        /// </summary>
        [Symbol("/1", SD.r1)]
        r1,

        /// <summary>
        /// <see cref='SD.r2'/>
        /// </summary>
        [Symbol("/2", SD.r2)]
        r2,

        /// <summary>
        /// <see cref='SD.r3'/>
        /// </summary>
        [Symbol("/3", SD.r3)]
        r3,

        /// <summary>
        /// <see cref='SD.r4'/>
        /// </summary>
        [Symbol("/4", SD.r4)]
        r4,

        /// <summary>
        /// <see cref='SD.r5'/>
        /// </summary>
        [Symbol("/5", SD.r5)]
        r5,

        /// <summary>
        /// <see cref='SD.r6'/>
        /// </summary>
        [Symbol("/6", SD.r6)]
        r6,

        /// <summary>
        /// <see cref='SD.r7'/>
        /// </summary>
        [Symbol("/7", SD.r7)]
        r7,

        [Symbol("VEX")]
        Vex,

        [Symbol("REX.W")]
        RexW,

        /// <summary>
        /// <see cref='SD.cb'/>
        /// </summary>
        [Symbol("cb", SD.cb)]
        cb,

        /// <summary>
        /// <see cref='SD.cw'/>
        /// </summary>
        [Symbol("cw", SD.cw)]
        cw,

        /// <summary>
        /// <see cref='SD.cd'/>
        /// </summary>
        [Symbol("cd", SD.cd)]
        cd,

        /// <summary>
        /// <see cref='SD.cp'/>
        /// </summary>
        [Symbol("cp", SD.cp)]
        cp,

        /// <summary>
        /// <see cref='SD.co'/>
        /// </summary>
        [Symbol("co", SD.co)]
        co,

        /// <summary>
        /// <see cref='SD.ct'/>
        /// </summary>
        [Symbol("ct", SD.ct)]
        ct,

        /// <summary>
        /// <see cref='SD.ib'/>
        /// </summary>
        [Symbol("ib", SD.ib)]
        ib,

        /// <summary>
        /// <see cref='SD.iw'/>
        /// </summary>
        [Symbol("iw", SD.iw)]
        iw,

        /// <summary>
        /// <see cref='SD.Id'/>
        /// </summary>
        [Symbol("id", SD.id)]
        id,

        /// <summary>
        /// <see cref='SD.io'/>
        /// </summary>
        [Symbol("io", SD.io)]
        io,

        /// <summary>
        /// <see cref='SD.ᕀrb'/>
        /// </summary>
        [Symbol("+rb",SD.ᕀrb)]
        rb,

        /// <summary>
        /// <see cref='SD.ᕀrw'/>
        /// </summary>
        [Symbol("+rw", SD.ᕀrw)]
        rw,

        /// <summary>
        /// <see cref='SD.ᕀrd'/>
        /// </summary>
        [Symbol("+rd",SD.ᕀrd)]
        rd,

        /// <summary>
        /// <see cref='SD.ᕀro'/>
        /// </summary>
        [Symbol("+ro",SD.ᕀro)]
        ro,

        [Symbol("r/m8", SD.rm8)]
        rm8,

        [Symbol("r/m16", SD.rm8)]
        rm16,

        [Symbol("r/m32", SD.rm8)]
        rm32,

        [Symbol("r/m64", SD.rm8)]
        rm64,

        [Symbol("reg/m8")]
        regM8,

        [Symbol("reg/m16")]
        regM16,

        [Symbol("reg/m32")]
        regM32,

        [Symbol("reg")]
        reg,

        [Symbol("m", SD.m)]
        m,

        [Symbol("mem")]
        mem,
    }
}