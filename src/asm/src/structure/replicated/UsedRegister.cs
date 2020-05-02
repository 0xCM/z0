//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    /// <summary>
    /// A register used by an instruction
    /// </summary>
    public readonly struct UsedRegister 
    {
        /// <summary>
        /// Register
        /// </summary>
        public Register Register {get;}

        /// <summary>
        /// Register access
        /// </summary>
        public OpAccess Access {get;}

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="register">Register</param>
        /// <param name="access">Register access</param>
        public UsedRegister(Register register, OpAccess access) 
        {
            this.Register = register;
            this.Access = access;
        }

        /// <summary>
        /// ToString()
        /// </summary>
        public override string ToString() => Register.ToString() + ":" + Access.ToString();
    }
}