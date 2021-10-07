//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using K = Circuits.GateKind;

    partial struct Circuits
    {
        public class Printer
        {
            [Op]
            static GateName identifier(GateKind src)
            {
                switch(src)
                {
                    case K.And:
                        return "and";
                    case K.Or:
                        return "or";
                    case K.Xor:
                        return "xor";
                    case K.Xnor:
                        return "xnor";
                    case K.Nor:
                        return "nor";
                    case K.Nand:
                        return "nand";
                    case K.Not:
                        return "not";
                    case K.Mux:
                        return "mux";
                }
                return '?';
            }

            [Op]
            static GateName symbol(GateKind src)
            {
                switch(src)
                {
                    case K.And:
                        return (char)LogicSym.And;
                    case K.Or:
                        return (char)LogicSym.Or;
                    case K.Xor:
                        return (char)LogicSym.Xor;
                    case K.Nand:
                        return (char)LogicSym.Nand;
                    case K.Nor:
                        return (char)LogicSym.Nor;
                    case K.Xnor:
                        return (char)LogicSym.Xnor;
                    case K.Not:
                        return (char)LogicSym.Not;
                }
                return '?';
            }
        }
    }
}