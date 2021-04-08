//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using OCD = AsmOpCodeDocs;

    [SymbolSource]
    public enum RegModifierToken : byte
    {
        None,

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

