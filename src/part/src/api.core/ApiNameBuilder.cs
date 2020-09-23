//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct ApiNameBuilder
    {
        public const string AreaPattern = "{0}";

        public const string SubjectPattern = "{0}.{1}";

        public const string SectorPattern = "{0}.{1}.{2}";

        public const string OwnedAreaPattern = "{0}.{1}";

        public const string OwnedSubjectPattern = "{0}.{1}.{2}";

        public const string OwnedSectorPattern = "{0}.{1}.{2}.{4}";

        public static string host(string name)
            => string.Format(AreaPattern, name);

        public static string host(string area, string subject)
            => string.Format(SubjectPattern,area, subject);

        public static string host(string area, string subject, string sector)
            => string.Format(SectorPattern, area, subject, sector);

        public static string host(PartId part, string name)
            => string.Format(OwnedAreaPattern, part.Format(), name);

        public static string host(PartId part, string area, string subject)
            => string.Format(OwnedSubjectPattern, part.Format(), area, subject);

        public static string host(PartId part,string area, string subject, string sector)
            => string.Format(OwnedSectorPattern, part.Format(), area, subject, sector);
    }
}