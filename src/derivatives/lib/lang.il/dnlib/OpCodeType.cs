//-----------------------------------------------------------------------------
// Taken from dnlib:https://github.com/0xd4d/dnlib
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct DnCilModel
    {
        /// <summary>
        /// CIL opcode type
        /// </summary>
        public enum OpCodeType : byte
        {
            /// <summary/>
            Annotation,
            /// <summary/>
            Macro,
            /// <summary/>
            Nternal,
            /// <summary/>
            Objmodel,
            /// <summary/>
            Prefix,
            /// <summary/>
            Primitive,
        }

    }
}