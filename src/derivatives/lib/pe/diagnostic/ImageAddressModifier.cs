//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    public enum ImageAddressModifier
    {
        /// <summary>
        /// An absolute address
        /// </summary>
        None = 0,

        /// <summary>
        /// A 64-bit virtual address
        /// </summary>
        Va64 = 1,

        /// <summary>
        /// A 32-bit virtual address
        /// </summary>
        Va32 = 2,

        /// <summary>
        /// An unbased 32-bit address (RVA)
        /// </summary>
        Rva32 = 3,

        /// <summary>
        /// A 32-bit RVA with a 1 byte offset
        /// </summary>
        Rva32x1 = 5,

        /// <summary>
        /// A 32-bit RVA with a 2 byte offset
        /// </summary>
        Rva32x2 = 6,

        /// <summary>
        /// A 32-bit RVA with a 3 byte offset
        /// </summary>
        Rva32x3 = 7,

        /// <summary>
        /// A 32-bit RVA with a 4 byte offset
        /// </summary>
        Rva32x4 = 8,

        /// <summary>
        /// A 32-bit RVA with a 5 byte offset
        /// </summary>
        Rva32x5 = 9,

        /// <summary>
        /// A section index
        /// </summary>
        Section = 10,

        /// <summary>
        /// A section-relative 32-bit offset
        /// </summary>
        SectionOffset = 11,

        /// <summary>
        /// A section-relative 7-bit offset
        /// </summary>
        SectionOffset7 = 12,

        /// <summary>
        /// A 32-bit metadata token
        /// </summary>
        Token=13
    }
}