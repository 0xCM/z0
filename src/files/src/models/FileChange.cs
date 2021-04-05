//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct FileChange : IRecord<FileChange>
    {
        public const string TableId = "fs.change";

        public FS.PathPart Subject;

        public FS.ObjectKind SubjectKind;

        public FS.ChangeKind ChangeKind;

        public FileChange(FS.PathPart name, FS.ObjectKind objkind, FS.ChangeKind kind)
        {
            ChangeKind = kind;
            SubjectKind = objkind;
            Subject = name;
        }
    }
}