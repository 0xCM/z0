//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// A register used by an instruction
    /// </summary>
    public readonly struct UsedRegister 
    {
        /// <summary>
        /// Register
        /// </summary>
        public readonly Register Register;

        /// <summary>
        /// Register access
        /// </summary>
        public readonly OpAccess Access;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="reg">Register</param>
        /// <param name="access">Register access</param>
        public UsedRegister(Register reg, OpAccess access) 
        {
            Register = reg;
            Access = access;
        }

        /// <summary>
        /// ToString()
        /// </summary>
        public override string ToString() 
            => Register.ToString() + ":" + Access.ToString();
    }
}