//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    using static BitParts;

    public class t_sb_bitparts : t_bitpart<t_sb_bitparts>
    {
        public void bitpart_10x1()
            => bitpart_check<uint,byte>(BitParts.part10x1, (int)Part10x1.Count,(int)Part10x1.Width);

        public void bitpart_32x1()
            => bitpart_check<uint,byte>(BitParts.part32x1, (int)Part32x1.Count,(int)Part32x1.Width);

        public void bitpart_64x1()
            => bitpart_check<ulong,byte>(BitParts.part64x1, (int)Part64x1.Count,(int)Part64x1.Width);

        public void bitpart_15x3()
            => bitpart_check<uint,byte>(BitParts.part15x3, (int)Part15x3.Count,(int)Part15x3.Width);

        public void bitpart_18x3()
            => bitpart_check<uint,byte>(BitParts.part18x3, (int)Part18x3.Count,(int)Part18x3.Width);

        public void bitpart_21x3()
            => bitpart_check<uint,byte>(BitParts.part21x3, (int)Part21x3.Count,(int)Part21x3.Width);

        public void bitpart_24x3()
            => bitpart_check<uint,byte>(BitParts.part24x3, (int)Part24x3.Count,(int)Part24x3.Width);

        public void bitpart_27x3()
            => bitpart_check<uint,byte>(BitParts.part27x3, (int)Part27x3.Count,(int)Part27x3.Width);

        public void bitpart_30x3()
            => bitpart_check<uint,byte>(BitParts.part30x3, (int)Part30x3.Count,(int)Part30x3.Width);

        public void bitpart_12x4()
            => bitpart_check<uint,byte>(BitParts.part12x4, (int)Part12x4.Count,(int)Part12x4.Width);

        public void bitpart_8x4()
            => bitpart_check<uint,byte>(BitParts.part8x4, (int)Part8x4.Count,(int)Part8x4.Width);

        public void bitpart_16x4()
            => bitpart_check<uint,byte>(BitParts.part16x4, (int)Part16x4.Count,(int)Part16x4.Width);

        public void bitpart_32x4()
            => bitpart_check<uint,byte>(BitParts.part32x4, (int)Part32x4.Count,(int)Part32x4.Width);

        public void bitpart_32x8()
            => bitpart_check<uint,byte>(BitParts.part32x8, (int)Part32x8.Count,(int)Part32x8.Width);

        public void bitpart_32x16()
            => bitpart_check<uint,ushort>(BitParts.part32x16, (int)Part32x16.Count, (int)Part32x16.Width);

    }

}