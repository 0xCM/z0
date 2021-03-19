//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using OCD = AsmOpCodeDocs;
    using OCT = AsmOpCodeToken;

    [SymbolSource]
    public enum RegModifierToken : byte
    {
        None,

        /// <summary>
        /// <see cref='OCD.ᕀrb'/>
        /// </summary>
        [Symbol("+rb",OCD.ᕀrb)]
        rb = OCT.rb,

        /// <summary>
        /// <see cref='OCD.ᕀrw'/>
        /// </summary>
        [Symbol("+rw", OCD.ᕀrw)]
        rw = OCT.rw,

        /// <summary>
        /// <see cref='OCD.ᕀrd'/>
        /// </summary>
        [Symbol("+rd",OCD.ᕀrd)]
        rd = OCT.rd,

        /// <summary>
        /// <see cref='OCD.ᕀro'/>
        /// </summary>
        [Symbol("+ro",OCD.ᕀro)]
        ro = OCT.ro,

        /// <summary>
        /// <see cref='OCD.ᕀrq'/>
        /// </summary>
        [Symbol("+ro",OCD.ᕀrq)]
        rq = OCT.rq,

    }
}

