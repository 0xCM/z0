//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IBitfieldModel
    {
        /// <summary>
        /// The bitfield name
        /// </summary>
        StringAddress Name {get;}

        /// <summary>
        /// The number of defined sections
        /// </summary>
        uint SectionCount {get;}

        /// <summary>
        /// The accumulated section widths
        /// </summary>
        uint TotalWidth {get;}

        /// <summary>
        /// The defined segments
        /// </summary>
        Span<BitfieldSection> Sections {get;}
    }

    public interface IBitfieldModel<T> : IBitfieldModel
        where T : unmanaged
    {
         new Span<BitfieldSection<T>> Sections {get;}

         Span<BitfieldSection> IBitfieldModel.Sections
            =>  Sections.Map(s => (BitfieldSection)s);
    }
}